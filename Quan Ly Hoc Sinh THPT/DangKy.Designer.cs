namespace Quan_Ly_Hoc_Sinh_THPT
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ttk = new System.Windows.Forms.TextBox();
            this.textBox_dk_mk = new System.Windows.Forms.TextBox();
            this.textBox_xnmk = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_dangky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xác nhận mật khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email :";
            // 
            // textBox_ttk
            // 
            this.textBox_ttk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ttk.Location = new System.Drawing.Point(352, 251);
            this.textBox_ttk.Name = "textBox_ttk";
            this.textBox_ttk.Size = new System.Drawing.Size(200, 27);
            this.textBox_ttk.TabIndex = 2;
            // 
            // textBox_dk_mk
            // 
            this.textBox_dk_mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dk_mk.Location = new System.Drawing.Point(352, 296);
            this.textBox_dk_mk.Name = "textBox_dk_mk";
            this.textBox_dk_mk.PasswordChar = '*';
            this.textBox_dk_mk.Size = new System.Drawing.Size(200, 27);
            this.textBox_dk_mk.TabIndex = 2;
            // 
            // textBox_xnmk
            // 
            this.textBox_xnmk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_xnmk.Location = new System.Drawing.Point(352, 338);
            this.textBox_xnmk.Name = "textBox_xnmk";
            this.textBox_xnmk.PasswordChar = '*';
            this.textBox_xnmk.Size = new System.Drawing.Size(200, 27);
            this.textBox_xnmk.TabIndex = 2;
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Location = new System.Drawing.Point(352, 383);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 27);
            this.textBox_email.TabIndex = 2;
            // 
            // button_dangky
            // 
            this.button_dangky.Location = new System.Drawing.Point(387, 465);
            this.button_dangky.Name = "button_dangky";
            this.button_dangky.Size = new System.Drawing.Size(97, 37);
            this.button_dangky.TabIndex = 3;
            this.button_dangky.Text = "Đăng Ký";
            this.button_dangky.UseVisualStyleBackColor = true;
            this.button_dangky.Click += new System.EventHandler(this.button_dangky_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button_dangky);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_xnmk);
            this.Controls.Add(this.textBox_dk_mk);
            this.Controls.Add(this.textBox_ttk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ttk;
        private System.Windows.Forms.TextBox textBox_dk_mk;
        private System.Windows.Forms.TextBox textBox_xnmk;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_dangky;
    }
}