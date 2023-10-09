namespace Quan_Ly_Hoc_Sinh_THPT
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_thongke = new System.Windows.Forms.ComboBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.button_thongke = new System.Windows.Forms.Button();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.GroupBox();
            this.groupBox_gioiTinh = new System.Windows.Forms.GroupBox();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.comboBox_Lop = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dateTimePicker_ngaySInh = new System.Windows.Forms.DateTimePicker();
            this.textBox_quequan = new System.Windows.Forms.TextBox();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.textBox_Mahs = new System.Windows.Forms.TextBox();
            this.label_gioiTinh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_dangXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Control.SuspendLayout();
            this.groupBox_gioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Học Sinh THPT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_thongke);
            this.groupBox1.Controls.Add(this.btn_timKiem);
            this.groupBox1.Controls.Add(this.button_thongke);
            this.groupBox1.Controls.Add(this.textBox_timKiem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1456, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "/";
            // 
            // comboBox_thongke
            // 
            this.comboBox_thongke.FormattingEnabled = true;
            this.comboBox_thongke.Items.AddRange(new object[] {
            "ALL",
            "10A",
            "10B",
            "10C",
            "10D",
            "11A",
            "11B",
            "11C",
            "11D",
            "12A",
            "12B",
            "12C",
            "12D"});
            this.comboBox_thongke.Location = new System.Drawing.Point(1114, 50);
            this.comboBox_thongke.Name = "comboBox_thongke";
            this.comboBox_thongke.Size = new System.Drawing.Size(121, 24);
            this.comboBox_thongke.TabIndex = 8;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(488, 39);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(88, 38);
            this.btn_timKiem.TabIndex = 2;
            this.btn_timKiem.Text = "Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // button_thongke
            // 
            this.button_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thongke.Location = new System.Drawing.Point(1281, 41);
            this.button_thongke.Name = "button_thongke";
            this.button_thongke.Size = new System.Drawing.Size(129, 38);
            this.button_thongke.TabIndex = 7;
            this.button_thongke.Text = "Thống Kê";
            this.button_thongke.UseVisualStyleBackColor = true;
            this.button_thongke.Click += new System.EventHandler(this.button_thongke_Click);
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(283, 50);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(149, 22);
            this.textBox_timKiem.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // Control
            // 
            this.Control.Controls.Add(this.groupBox_gioiTinh);
            this.Control.Controls.Add(this.comboBox_Lop);
            this.Control.Controls.Add(this.btn_xoa);
            this.Control.Controls.Add(this.btn_sua);
            this.Control.Controls.Add(this.btn_them);
            this.Control.Controls.Add(this.dateTimePicker_ngaySInh);
            this.Control.Controls.Add(this.textBox_quequan);
            this.Control.Controls.Add(this.textBox_ten);
            this.Control.Controls.Add(this.textBox_Mahs);
            this.Control.Controls.Add(this.label_gioiTinh);
            this.Control.Controls.Add(this.label6);
            this.Control.Controls.Add(this.label5);
            this.Control.Controls.Add(this.label4);
            this.Control.Controls.Add(this.label3);
            this.Control.Controls.Add(this.label2);
            this.Control.Location = new System.Drawing.Point(967, 240);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(501, 470);
            this.Control.TabIndex = 3;
            this.Control.TabStop = false;
            this.Control.Text = ".";
            // 
            // groupBox_gioiTinh
            // 
            this.groupBox_gioiTinh.Controls.Add(this.radioButton_nam);
            this.groupBox_gioiTinh.Controls.Add(this.radioButton_nu);
            this.groupBox_gioiTinh.Location = new System.Drawing.Point(182, 274);
            this.groupBox_gioiTinh.Name = "groupBox_gioiTinh";
            this.groupBox_gioiTinh.Size = new System.Drawing.Size(163, 39);
            this.groupBox_gioiTinh.TabIndex = 9;
            this.groupBox_gioiTinh.TabStop = false;
            this.groupBox_gioiTinh.Text = ".";
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Location = new System.Drawing.Point(23, 13);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(57, 20);
            this.radioButton_nam.TabIndex = 0;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Location = new System.Drawing.Point(100, 13);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(45, 20);
            this.radioButton_nu.TabIndex = 0;
            this.radioButton_nu.TabStop = true;
            this.radioButton_nu.Text = "Nu";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // comboBox_Lop
            // 
            this.comboBox_Lop.FormattingEnabled = true;
            this.comboBox_Lop.Items.AddRange(new object[] {
            "10A",
            "10B",
            "10C",
            "10D",
            "11A",
            "11B",
            "11C",
            "11D",
            "12A",
            "12B",
            "12C",
            "12D"});
            this.comboBox_Lop.Location = new System.Drawing.Point(182, 163);
            this.comboBox_Lop.Name = "comboBox_Lop";
            this.comboBox_Lop.Size = new System.Drawing.Size(154, 24);
            this.comboBox_Lop.TabIndex = 8;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(294, 406);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 36);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(159, 406);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(91, 36);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(17, 406);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(91, 36);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dateTimePicker_ngaySInh
            // 
            this.dateTimePicker_ngaySInh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaySInh.Location = new System.Drawing.Point(182, 230);
            this.dateTimePicker_ngaySInh.Name = "dateTimePicker_ngaySInh";
            this.dateTimePicker_ngaySInh.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker_ngaySInh.TabIndex = 3;
            // 
            // textBox_quequan
            // 
            this.textBox_quequan.Location = new System.Drawing.Point(182, 347);
            this.textBox_quequan.Name = "textBox_quequan";
            this.textBox_quequan.Size = new System.Drawing.Size(154, 22);
            this.textBox_quequan.TabIndex = 1;
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(182, 96);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(154, 22);
            this.textBox_ten.TabIndex = 1;
            this.textBox_ten.TextChanged += new System.EventHandler(this.textBox_ten_TextChanged);
            // 
            // textBox_Mahs
            // 
            this.textBox_Mahs.Location = new System.Drawing.Point(182, 33);
            this.textBox_Mahs.Name = "textBox_Mahs";
            this.textBox_Mahs.Size = new System.Drawing.Size(154, 22);
            this.textBox_Mahs.TabIndex = 1;
            // 
            // label_gioiTinh
            // 
            this.label_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gioiTinh.Location = new System.Drawing.Point(13, 288);
            this.label_gioiTinh.Name = "label_gioiTinh";
            this.label_gioiTinh.Size = new System.Drawing.Size(100, 25);
            this.label_gioiTinh.TabIndex = 0;
            this.label_gioiTinh.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "MãHS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(910, 470);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_dangXuat
            // 
            this.button_dangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_dangXuat.Location = new System.Drawing.Point(1353, 745);
            this.button_dangXuat.Name = "button_dangXuat";
            this.button_dangXuat.Size = new System.Drawing.Size(99, 28);
            this.button_dangXuat.TabIndex = 4;
            this.button_dangXuat.Text = "Đăng Xuất";
            this.button_dangXuat.UseVisualStyleBackColor = false;
            this.button_dangXuat.Click += new System.EventHandler(this.button_dangXuat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1498, 776);
            this.Controls.Add(this.button_dangXuat);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Học Sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.groupBox_gioiTinh.ResumeLayout(false);
            this.groupBox_gioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.TextBox textBox_Mahs;
        private System.Windows.Forms.TextBox textBox_quequan;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaySInh;
        private System.Windows.Forms.TextBox textBox_timKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_thongke;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.ComboBox comboBox_Lop;
        private System.Windows.Forms.ComboBox comboBox_thongke;
        private System.Windows.Forms.GroupBox groupBox_gioiTinh;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.Label label_gioiTinh;
        private System.Windows.Forms.Button button_dangXuat;
    }
}

