namespace Quan_Ly_Hoc_Sinh_THPT
{
    partial class dangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel_quenmk = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dk = new System.Windows.Forms.LinkLabel();
            this.button_dn = new System.Windows.Forms.Button();
            this.label_tendn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dn_tdangn = new System.Windows.Forms.TextBox();
            this.textBox_dn_mk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel_quenmk
            // 
            this.linkLabel_quenmk.AutoSize = true;
            this.linkLabel_quenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_quenmk.Location = new System.Drawing.Point(148, 425);
            this.linkLabel_quenmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_quenmk.Name = "linkLabel_quenmk";
            this.linkLabel_quenmk.Size = new System.Drawing.Size(125, 20);
            this.linkLabel_quenmk.TabIndex = 1;
            this.linkLabel_quenmk.TabStop = true;
            this.linkLabel_quenmk.Text = "Quên Mật Khẩu";
            this.linkLabel_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenmk_LinkClicked);
            // 
            // linkLabel_dk
            // 
            this.linkLabel_dk.AutoSize = true;
            this.linkLabel_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_dk.Location = new System.Drawing.Point(478, 425);
            this.linkLabel_dk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_dk.Name = "linkLabel_dk";
            this.linkLabel_dk.Size = new System.Drawing.Size(79, 20);
            this.linkLabel_dk.TabIndex = 1;
            this.linkLabel_dk.TabStop = true;
            this.linkLabel_dk.Text = "Đăng Ký";
            this.linkLabel_dk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dk_LinkClicked);
            // 
            // button_dn
            // 
            this.button_dn.Location = new System.Drawing.Point(309, 476);
            this.button_dn.Margin = new System.Windows.Forms.Padding(4);
            this.button_dn.Name = "button_dn";
            this.button_dn.Size = new System.Drawing.Size(139, 51);
            this.button_dn.TabIndex = 2;
            this.button_dn.Text = "Đăng Nhập";
            this.button_dn.UseVisualStyleBackColor = true;
            this.button_dn.Click += new System.EventHandler(this.button_dn_Click);
            // 
            // label_tendn
            // 
            this.label_tendn.AutoSize = true;
            this.label_tendn.Location = new System.Drawing.Point(80, 297);
            this.label_tendn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tendn.Name = "label_tendn";
            this.label_tendn.Size = new System.Drawing.Size(125, 20);
            this.label_tendn.TabIndex = 3;
            this.label_tendn.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật Khẩu";
            // 
            // textBox_dn_tdangn
            // 
            this.textBox_dn_tdangn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dn_tdangn.Location = new System.Drawing.Point(283, 290);
            this.textBox_dn_tdangn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dn_tdangn.Name = "textBox_dn_tdangn";
            this.textBox_dn_tdangn.Size = new System.Drawing.Size(204, 27);
            this.textBox_dn_tdangn.TabIndex = 5;
            // 
            // textBox_dn_mk
            // 
            this.textBox_dn_mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dn_mk.Location = new System.Drawing.Point(283, 346);
            this.textBox_dn_mk.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dn_mk.Name = "textBox_dn_mk";
            this.textBox_dn_mk.PasswordChar = '*';
            this.textBox_dn_mk.Size = new System.Drawing.Size(204, 27);
            this.textBox_dn_mk.TabIndex = 5;
            // 
            // dangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(767, 577);
            this.Controls.Add(this.textBox_dn_mk);
            this.Controls.Add(this.textBox_dn_tdangn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_tendn);
            this.Controls.Add(this.button_dn);
            this.Controls.Add(this.linkLabel_dk);
            this.Controls.Add(this.linkLabel_quenmk);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dangNhap";
            this.Load += new System.EventHandler(this.dangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel_quenmk;
        private System.Windows.Forms.LinkLabel linkLabel_dk;
        private System.Windows.Forms.Button button_dn;
        private System.Windows.Forms.Label label_tendn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dn_tdangn;
        private System.Windows.Forms.TextBox textBox_dn_mk;
    }
}