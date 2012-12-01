using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace CarPlate_Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();
                Image<Gray, byte> smooth_image = My_Image.Convert<Gray, byte>();
                Image<Gray, byte> dae_gray_image = My_Image.Convert<Gray, byte>();
                Image<Gray, byte> bi_gray_image = My_Image.Convert<Gray, byte>();
                Image<Gray, byte> ed_gray_image = new Image<Gray, byte>(gray_image.Size);
                Image<Bgr, byte> final_image = new Image<Bgr, byte>(Openfile.FileName);
                MemStorage stor = new MemStorage();
                List<MCvBox2D> detectedLicensePlateRegionList = new List<MCvBox2D>();

                //CvInvoke.cvEqualizeHist(gray_image, gray_image);
                CvInvoke.cvSmooth(gray_image, smooth_image, Emgu.CV.CvEnum.SMOOTH_TYPE.CV_GAUSSIAN, 3, 3, 0, 0);

                

                CvInvoke.cvDilate(smooth_image, dae_gray_image, IntPtr.Zero, 100);
                CvInvoke.cvErode(dae_gray_image, dae_gray_image, IntPtr.Zero, 100);
                dae_gray_image = dae_gray_image - smooth_image;


                //CvInvoke.cvErode(smooth_image, dae_gray_image, IntPtr.Zero, 100);
                //CvInvoke.cvDilate(dae_gray_image, dae_gray_image, IntPtr.Zero, 100);
                //dae_gray_image = smooth_image - dae_gray_image;



                int i, thre;
                int[] pg = new int[256];
                for (i = 0; i < 256; i++) pg[i] = 0;
                int w = dae_gray_image.Width;
                int h = dae_gray_image.Height;
                int[] hist_size = new int[1] { 256 };
                IntPtr HistImg = CvInvoke.cvCreateHist(1, hist_size, Emgu.CV.CvEnum.HIST_TYPE.CV_HIST_ARRAY, null, 1);
                IntPtr[] inPtr1 = new IntPtr[1] { dae_gray_image };
                CvInvoke.cvCalcHist(inPtr1, HistImg, false, System.IntPtr.Zero);
                for (i = 0; i < 256; i++)
                {
                    pg[i] = (int)CvInvoke.cvQueryHistValue_1D(HistImg, i);

                }
                thre = BasicGlobalThreshold(pg, 0, 256);

                CvInvoke.cvThreshold(dae_gray_image, bi_gray_image, thre, 255, Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY);
                CvInvoke.cvCanny(bi_gray_image, ed_gray_image, 100, 50, 3);


                CvInvoke.cvDilate(ed_gray_image, ed_gray_image, IntPtr.Zero, 1);
                CvInvoke.cvErode(ed_gray_image, ed_gray_image, IntPtr.Zero, 1);
                



                Contour<Point> contours = ed_gray_image.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, stor);
                DetectPlate(contours, detectedLicensePlateRegionList);

                for (i = 0; i < detectedLicensePlateRegionList.Count; i++)
                {
                    final_image.Draw(detectedLicensePlateRegionList[i], new Bgr(Color.Red), 2);
                }


                imageBox1.Image = My_Image;
                imageBox2.Image = smooth_image;
                imageBox3.Image = dae_gray_image;
                imageBox4.Image = bi_gray_image;
                imageBox5.Image = ed_gray_image;
                imageBox6.Image = final_image;



            }
        }

        private static int GetNumberOfChildren(Contour<Point> contours)
        {
            Contour<Point> child = contours.VNext;
            if (child == null) return 0;
            int count = 0;
            while (child != null)
            {
                count++;
                child = child.HNext;
            }
            return count;
        }


        private void DetectPlate(Contour<Point> contours, List<MCvBox2D> detectedLicensePlateRegionList)
        {
            for (; contours != null; contours = contours.HNext)
            {
                int numberOfChildren = GetNumberOfChildren(contours);
                if (numberOfChildren == 0) continue;

                if (contours.Area > 400)
                {
                    if (numberOfChildren < 3)
                    {
                        DetectPlate(contours.VNext, detectedLicensePlateRegionList);
                        continue;
                    }

                    MCvBox2D box = contours.GetMinAreaRect();
                    if (box.angle < -45.0)
                    {
                        float tmp = box.size.Width;
                        box.size.Width = box.size.Height;
                        box.size.Height = tmp;
                        box.angle += 90.0f;
                    }
                    else if (box.angle > 45.0)
                    {
                        float tmp = box.size.Width;
                        box.size.Width = box.size.Height;
                        box.size.Height = tmp;
                        box.angle -= 90.0f;
                    }

                    double whRatio = (double)box.size.Width / box.size.Height;
                    if (!(3.0 < whRatio && whRatio < 10.0))
                    {
                        Contour<Point> child = contours.VNext;
                        if (child != null)
                            DetectPlate(child, detectedLicensePlateRegionList);
                        continue;
                    }
                    detectedLicensePlateRegionList.Add(box);
                }
            }
        }

        private int BasicGlobalThreshold(int[] pg, int start, int end)
        {
            int i, t, t1, t2, k1, k2;
            double u, u1, u2;
            t = 0;
            u = 0;
            for (i = start; i < end; i++)
            {
                t += pg[i];
                u += i * pg[i];
            }
            k2 = (int)(u / t);
            do
            {
                k1 = k2;
                t1 = 0;
                u1 = 0;
                for (i = start; i <= k1; i++)
                {
                    t1 += pg[i];
                    u1 += i * pg[i];
                }
                t2 = t - t1;
                u2 = u - u1;
                if (t1 != 0)
                {
                    u1 = u1 / t1;
                }
                else
                {
                    u1 = 0;
                }
                if (t2 != 0)
                {
                    u2 = u2 / t2;
                }
                else
                {
                    u2 = 0;
                }

                k2 = (int)((u1 + u2) / 2);
            }
            while (k1 != k2);
            return (k1);
        }

    }
}
