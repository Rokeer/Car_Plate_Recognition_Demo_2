namespace CarPlate_Demo_2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBox6 = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(897, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "Final Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "Edge Detection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "Binarization Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dilate and Erode Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gray and Smooth Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Original Image";
            // 
            // imageBox6
            // 
            this.imageBox6.Location = new System.Drawing.Point(743, 396);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(361, 289);
            this.imageBox6.TabIndex = 20;
            this.imageBox6.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.Location = new System.Drawing.Point(378, 396);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(361, 289);
            this.imageBox5.TabIndex = 19;
            this.imageBox5.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.Location = new System.Drawing.Point(11, 396);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(361, 289);
            this.imageBox4.TabIndex = 18;
            this.imageBox4.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(745, 59);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(361, 289);
            this.imageBox3.TabIndex = 17;
            this.imageBox3.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(378, 59);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(361, 289);
            this.imageBox2.TabIndex = 16;
            this.imageBox2.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(11, 59);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(361, 289);
            this.imageBox1.TabIndex = 15;
            this.imageBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox6);
            this.Controls.Add(this.imageBox5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "License Plate Recognition Demo(Dilate&Erode Method)";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox imageBox6;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}

