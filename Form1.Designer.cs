namespace SimpleCalculatorProjectWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDev = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAns = new System.Windows.Forms.Label();
            this.LblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClear.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClear.Location = new System.Drawing.Point(55, 609);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(92, 66);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDot.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDot.Location = new System.Drawing.Point(297, 609);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(92, 66);
            this.BtnDot.TabIndex = 1;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn7.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn7.Location = new System.Drawing.Point(55, 315);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(92, 66);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn6.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn6.Location = new System.Drawing.Point(297, 413);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(92, 66);
            this.Btn6.TabIndex = 3;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn5.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn5.Location = new System.Drawing.Point(176, 413);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(92, 66);
            this.Btn5.TabIndex = 4;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn4.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn4.Location = new System.Drawing.Point(55, 413);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(92, 66);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn3.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn3.Location = new System.Drawing.Point(297, 511);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(92, 66);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn2.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn2.Location = new System.Drawing.Point(176, 511);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(92, 66);
            this.Btn2.TabIndex = 7;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn1.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn1.Location = new System.Drawing.Point(55, 511);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(92, 66);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDel.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDel.Location = new System.Drawing.Point(437, 315);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(200, 66);
            this.BtnDel.TabIndex = 9;
            this.BtnDel.Text = "D";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMul.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMul.Location = new System.Drawing.Point(437, 413);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(92, 66);
            this.BtnMul.TabIndex = 10;
            this.BtnMul.Tag = "*";
            this.BtnMul.Text = "×";
            this.BtnMul.UseVisualStyleBackColor = false;
            this.BtnMul.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnDev
            // 
            this.BtnDev.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDev.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDev.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDev.Location = new System.Drawing.Point(545, 413);
            this.BtnDev.Name = "BtnDev";
            this.BtnDev.Size = new System.Drawing.Size(92, 66);
            this.BtnDev.TabIndex = 11;
            this.BtnDev.Tag = "/";
            this.BtnDev.Text = "÷";
            this.BtnDev.UseVisualStyleBackColor = false;
            this.BtnDev.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSub.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSub.Location = new System.Drawing.Point(437, 511);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(92, 66);
            this.BtnSub.TabIndex = 12;
            this.BtnSub.Tag = "-";
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = false;
            this.BtnSub.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEqual.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEqual.Location = new System.Drawing.Point(545, 512);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(92, 164);
            this.BtnEqual.TabIndex = 13;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAdd.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.Location = new System.Drawing.Point(437, 609);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 66);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Tag = "+";
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn0.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn0.Location = new System.Drawing.Point(176, 609);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(92, 66);
            this.Btn0.TabIndex = 15;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn9.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn9.Location = new System.Drawing.Point(297, 315);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(92, 66);
            this.Btn9.TabIndex = 16;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn8.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn8.Location = new System.Drawing.Point(176, 315);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(92, 66);
            this.Btn8.TabIndex = 17;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 52);
            this.label1.TabIndex = 18;
            this.label1.Text = "Simple Calculator";
            // 
            // LblAns
            // 
            this.LblAns.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblAns.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAns.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAns.Location = new System.Drawing.Point(55, 146);
            this.LblAns.Name = "LblAns";
            this.LblAns.Size = new System.Drawing.Size(582, 137);
            this.LblAns.TabIndex = 19;
            this.LblAns.Text = "00";
            // 
            // LblShow
            // 
            this.LblShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblShow.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShow.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblShow.Location = new System.Drawing.Point(55, 93);
            this.LblShow.Name = "LblShow";
            this.LblShow.Size = new System.Drawing.Size(582, 53);
            this.LblShow.TabIndex = 20;
            this.LblShow.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 713);
            this.Controls.Add(this.LblShow);
            this.Controls.Add(this.LblAns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnDev);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnClear);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDev;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAns;
        private System.Windows.Forms.Label LblShow;
    }
}

