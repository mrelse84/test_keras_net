
namespace test_keras_net
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputSLR = new System.Windows.Forms.TextBox();
            this.btnPredictSLR = new System.Windows.Forms.Button();
            this.btnLoadModelSLR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInputMLR3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInputMLR2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputMLR1 = new System.Windows.Forms.TextBox();
            this.btnPredictMLR = new System.Windows.Forms.Button();
            this.btnLoadModelMLR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPredictBC = new System.Windows.Forms.Button();
            this.btnLoadModelBC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radX0 = new System.Windows.Forms.RadioButton();
            this.radX4 = new System.Windows.Forms.RadioButton();
            this.radX6 = new System.Windows.Forms.RadioButton();
            this.lblXData = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPredictFashion = new System.Windows.Forms.Button();
            this.btnLoadModelFashion = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result :";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(69, 298);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(682, 26);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInputSLR);
            this.panel1.Controls.Add(this.btnPredictSLR);
            this.panel1.Controls.Add(this.btnLoadModelSLR);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 234);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "x :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Input";
            // 
            // txtInputSLR
            // 
            this.txtInputSLR.Location = new System.Drawing.Point(56, 111);
            this.txtInputSLR.Name = "txtInputSLR";
            this.txtInputSLR.Size = new System.Drawing.Size(86, 21);
            this.txtInputSLR.TabIndex = 10;
            this.txtInputSLR.Text = "10.0";
            this.txtInputSLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPredictSLR
            // 
            this.btnPredictSLR.Location = new System.Drawing.Point(27, 197);
            this.btnPredictSLR.Name = "btnPredictSLR";
            this.btnPredictSLR.Size = new System.Drawing.Size(115, 23);
            this.btnPredictSLR.TabIndex = 9;
            this.btnPredictSLR.Text = "Predict";
            this.btnPredictSLR.UseVisualStyleBackColor = true;
            this.btnPredictSLR.Click += new System.EventHandler(this.btnPredictSLR_Click);
            // 
            // btnLoadModelSLR
            // 
            this.btnLoadModelSLR.Location = new System.Drawing.Point(27, 11);
            this.btnLoadModelSLR.Name = "btnLoadModelSLR";
            this.btnLoadModelSLR.Size = new System.Drawing.Size(115, 23);
            this.btnLoadModelSLR.TabIndex = 8;
            this.btnLoadModelSLR.Text = "Load Model";
            this.btnLoadModelSLR.UseVisualStyleBackColor = true;
            this.btnLoadModelSLR.Click += new System.EventHandler(this.btnLoadModelSLR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Simple Linear Regression";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Multiple Linear Regression";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtInputMLR3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtInputMLR2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtInputMLR1);
            this.panel2.Controls.Add(this.btnPredictMLR);
            this.panel2.Controls.Add(this.btnLoadModelMLR);
            this.panel2.Location = new System.Drawing.Point(200, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 234);
            this.panel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "x3 :";
            // 
            // txtInputMLR3
            // 
            this.txtInputMLR3.Location = new System.Drawing.Point(56, 140);
            this.txtInputMLR3.Name = "txtInputMLR3";
            this.txtInputMLR3.Size = new System.Drawing.Size(86, 21);
            this.txtInputMLR3.TabIndex = 16;
            this.txtInputMLR3.Text = "-3.0";
            this.txtInputMLR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "x2 :";
            // 
            // txtInputMLR2
            // 
            this.txtInputMLR2.Location = new System.Drawing.Point(56, 111);
            this.txtInputMLR2.Name = "txtInputMLR2";
            this.txtInputMLR2.Size = new System.Drawing.Size(86, 21);
            this.txtInputMLR2.TabIndex = 14;
            this.txtInputMLR2.Text = "2.0";
            this.txtInputMLR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "x1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Input";
            // 
            // txtInputMLR1
            // 
            this.txtInputMLR1.Location = new System.Drawing.Point(56, 81);
            this.txtInputMLR1.Name = "txtInputMLR1";
            this.txtInputMLR1.Size = new System.Drawing.Size(86, 21);
            this.txtInputMLR1.TabIndex = 10;
            this.txtInputMLR1.Text = "11.0";
            this.txtInputMLR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPredictMLR
            // 
            this.btnPredictMLR.Location = new System.Drawing.Point(27, 197);
            this.btnPredictMLR.Name = "btnPredictMLR";
            this.btnPredictMLR.Size = new System.Drawing.Size(115, 23);
            this.btnPredictMLR.TabIndex = 9;
            this.btnPredictMLR.Text = "Predict";
            this.btnPredictMLR.UseVisualStyleBackColor = true;
            this.btnPredictMLR.Click += new System.EventHandler(this.btnPredictMLR_Click);
            // 
            // btnLoadModelMLR
            // 
            this.btnLoadModelMLR.Location = new System.Drawing.Point(27, 11);
            this.btnLoadModelMLR.Name = "btnLoadModelMLR";
            this.btnLoadModelMLR.Size = new System.Drawing.Size(115, 23);
            this.btnLoadModelMLR.TabIndex = 8;
            this.btnLoadModelMLR.Text = "Load Model";
            this.btnLoadModelMLR.UseVisualStyleBackColor = true;
            this.btnLoadModelMLR.Click += new System.EventHandler(this.btnLoadModelMLR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "Binomial Classification";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnPredictBC);
            this.panel3.Controls.Add(this.btnLoadModelBC);
            this.panel3.Location = new System.Drawing.Point(389, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 234);
            this.panel3.TabIndex = 10;
            // 
            // btnPredictBC
            // 
            this.btnPredictBC.Location = new System.Drawing.Point(27, 197);
            this.btnPredictBC.Name = "btnPredictBC";
            this.btnPredictBC.Size = new System.Drawing.Size(115, 23);
            this.btnPredictBC.TabIndex = 9;
            this.btnPredictBC.Text = "Predict";
            this.btnPredictBC.UseVisualStyleBackColor = true;
            this.btnPredictBC.Click += new System.EventHandler(this.btnPredictBC_Click);
            // 
            // btnLoadModelBC
            // 
            this.btnLoadModelBC.Location = new System.Drawing.Point(27, 11);
            this.btnLoadModelBC.Name = "btnLoadModelBC";
            this.btnLoadModelBC.Size = new System.Drawing.Size(115, 23);
            this.btnLoadModelBC.TabIndex = 8;
            this.btnLoadModelBC.Text = "Load Model";
            this.btnLoadModelBC.UseVisualStyleBackColor = true;
            this.btnLoadModelBC.Click += new System.EventHandler(this.btnLoadModelBC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblXData);
            this.groupBox1.Controls.Add(this.radX6);
            this.groupBox1.Controls.Add(this.radX4);
            this.groupBox1.Controls.Add(this.radX0);
            this.groupBox1.Location = new System.Drawing.Point(19, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Input";
            // 
            // radX0
            // 
            this.radX0.AutoSize = true;
            this.radX0.Location = new System.Drawing.Point(17, 20);
            this.radX0.Name = "radX0";
            this.radX0.Size = new System.Drawing.Size(48, 16);
            this.radX0.TabIndex = 0;
            this.radX0.Text = "x[0]";
            this.radX0.UseVisualStyleBackColor = true;
            this.radX0.CheckedChanged += new System.EventHandler(this.radX0_CheckedChanged);
            // 
            // radX4
            // 
            this.radX4.AutoSize = true;
            this.radX4.Location = new System.Drawing.Point(69, 20);
            this.radX4.Name = "radX4";
            this.radX4.Size = new System.Drawing.Size(48, 16);
            this.radX4.TabIndex = 1;
            this.radX4.Text = "x[4]";
            this.radX4.UseVisualStyleBackColor = true;
            this.radX4.CheckedChanged += new System.EventHandler(this.radX4_CheckedChanged);
            // 
            // radX6
            // 
            this.radX6.AutoSize = true;
            this.radX6.Checked = true;
            this.radX6.Location = new System.Drawing.Point(17, 42);
            this.radX6.Name = "radX6";
            this.radX6.Size = new System.Drawing.Size(48, 16);
            this.radX6.TabIndex = 2;
            this.radX6.TabStop = true;
            this.radX6.Text = "x[6]";
            this.radX6.UseVisualStyleBackColor = true;
            this.radX6.CheckedChanged += new System.EventHandler(this.radX6_CheckedChanged);
            // 
            // lblXData
            // 
            this.lblXData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXData.Location = new System.Drawing.Point(6, 61);
            this.lblXData.Name = "lblXData";
            this.lblXData.Size = new System.Drawing.Size(111, 77);
            this.lblXData.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(578, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fashion MNIST Classification";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnLoadImage);
            this.panel4.Controls.Add(this.picImage);
            this.panel4.Controls.Add(this.btnPredictFashion);
            this.panel4.Controls.Add(this.btnLoadModelFashion);
            this.panel4.Location = new System.Drawing.Point(579, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 234);
            this.panel4.TabIndex = 13;
            // 
            // btnPredictFashion
            // 
            this.btnPredictFashion.Location = new System.Drawing.Point(27, 197);
            this.btnPredictFashion.Name = "btnPredictFashion";
            this.btnPredictFashion.Size = new System.Drawing.Size(115, 23);
            this.btnPredictFashion.TabIndex = 9;
            this.btnPredictFashion.Text = "Predict";
            this.btnPredictFashion.UseVisualStyleBackColor = true;
            this.btnPredictFashion.Click += new System.EventHandler(this.btnPredictFashion_Click);
            // 
            // btnLoadModelFashion
            // 
            this.btnLoadModelFashion.Location = new System.Drawing.Point(27, 11);
            this.btnLoadModelFashion.Name = "btnLoadModelFashion";
            this.btnLoadModelFashion.Size = new System.Drawing.Size(115, 23);
            this.btnLoadModelFashion.TabIndex = 8;
            this.btnLoadModelFashion.Text = "Load Model";
            this.btnLoadModelFashion.UseVisualStyleBackColor = true;
            this.btnLoadModelFashion.Click += new System.EventHandler(this.btnLoadModelFashion_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(27, 72);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(115, 115);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(27, 44);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(115, 23);
            this.btnLoadImage.TabIndex = 11;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 352);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "test_keras_net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadModelSLR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputSLR;
        private System.Windows.Forms.Button btnPredictSLR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInputMLR3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInputMLR2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputMLR1;
        private System.Windows.Forms.Button btnPredictMLR;
        private System.Windows.Forms.Button btnLoadModelMLR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblXData;
        private System.Windows.Forms.RadioButton radX6;
        private System.Windows.Forms.RadioButton radX4;
        private System.Windows.Forms.RadioButton radX0;
        private System.Windows.Forms.Button btnPredictBC;
        private System.Windows.Forms.Button btnLoadModelBC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPredictFashion;
        private System.Windows.Forms.Button btnLoadModelFashion;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox picImage;
    }
}

