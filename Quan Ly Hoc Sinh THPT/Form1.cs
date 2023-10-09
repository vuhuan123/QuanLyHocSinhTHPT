using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Quan_Ly_Hoc_Sinh_THPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\WorkSpace\\C#\\Quan Ly Hoc Sinh THPT\\Quan Ly Hoc Sinh THPT\\Database1.mdf\";Integrated Security=True");

        public void hienthi()
        {
            connection.Open();
            string query = "select * from QLSV";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            dataGridView1.DataSource = dataTable;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maSV = textBox_Mahs.Text;
            string tenSV = textBox_ten.Text;
            string comboBox_L = comboBox_Lop.Text;
            string date = dateTimePicker_ngaySInh.Value.ToString("yyyy-MM-dd");
            string qq = textBox_quequan.Text;
            string Gioitinh = radioButton_nam.Checked ? radioButton_nam.Text : radioButton_nu.Text;

            // Kiểm tra trùng lặp Mã sinh viên trong cơ sở dữ liệu
            bool isDuplicate = CheckDuplicateMaSV(maSV);

            if (isDuplicate)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không thực hiện lưu dữ liệu
            }
            else if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(tenSV) || string.IsNullOrWhiteSpace(comboBox_L) || string.IsNullOrWhiteSpace(qq) || string.IsNullOrWhiteSpace(Gioitinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else {

                connection.Open();
                 string query = "Insert into QLSV values ('"+ maSV + "','"+ tenSV + "','"+ comboBox_L + "','"+ date + "','"+ qq + "','"+ Gioitinh + "')";
                SqlCommand command = new SqlCommand(query,connection);
                command.ExecuteNonQuery();
                connection.Close();
                hienthi();
            }


        }
        private bool CheckDuplicateMaSV(string maSV)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM QLSV WHERE MaHS = '"+textBox_Mahs.Text+"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSV", maSV);
                int count = (int)command.ExecuteScalar();
                connection.Close();
                return count > 0;  

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maSV = textBox_Mahs.Text;
            string tenSV = textBox_ten.Text;
            string comboBox_L = comboBox_Lop.Text;
            string date = dateTimePicker_ngaySInh.Value.ToString("yyyy-MM-dd");
            string qq = textBox_quequan.Text; 
            string Gioitinh = radioButton_nam.Checked ? radioButton_nam.Text : radioButton_nu.Text;

            if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(tenSV) || string.IsNullOrWhiteSpace(comboBox_L) || string.IsNullOrWhiteSpace(qq) || string.IsNullOrWhiteSpace(Gioitinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
            connection.Open();
            string query = "update QLSV set MaHS = '"+ maSV + "', HoTen = N'"+ tenSV + "', Lop = '"+ comboBox_L+"', NgaySinh = '"+ date + "', GioiTinh =  '"+Gioitinh+"',QueQuan = '"+ qq + "' where MaHS = '"+maSV+"' ";
            SqlCommand sqlCommand = new SqlCommand(query,connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close(); 
            hienthi();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "delete QLSV where MaHS = '"+textBox_Mahs.Text+"' ";
            SqlCommand cmd = new SqlCommand(query,connection); 
            cmd.ExecuteNonQuery();
            connection.Close();
            hienthi();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "Select * from QLSV where MaHS = '"+textBox_timKiem.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;  
             
        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            if(comboBox_thongke.Text == "ALL")
            {
                hienthi();
         
            }
            else
            {

                connection.Open();
                string query = "Select * from QLSV where Lop = '" + comboBox_thongke.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                dataGridView1.DataSource = dt;

            }
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Gioitinh = radioButton_nam.Checked ? radioButton_nam.Text : radioButton_nu.Text;
            int t = dataGridView1.CurrentCell.RowIndex;
            textBox_Mahs.Text = dataGridView1.Rows[t].Cells[0].Value.ToString();
            textBox_ten.Text = dataGridView1.Rows[t].Cells[1].Value.ToString();
            comboBox_Lop.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            dateTimePicker_ngaySInh.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
            textBox_quequan.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
            Gioitinh = dataGridView1.Rows[t].Cells[5].Value.ToString();
        }

        private void textBox_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_dangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuât không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                dangNhap dangNhap = new dangNhap();
                dangNhap.ShowDialog();

            }
        }
    }
}
