using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hoc_Sinh_THPT
{
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();   

        private void linkLabel_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenmk = new QuenMatKhau(); 
            quenmk.ShowDialog();
        }

        private void linkLabel_dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangNhap dangNhap = new dangNhap();
            dangNhap.Hide();
            DangKy dk = new DangKy();
             dk.ShowDialog();
            dangNhap.Close();   
        }

        private void button_dn_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = textBox_dn_tdangn.Text;
            string matKhau = textBox_dn_mk.Text;

            if(tenTaiKhoan.Trim() == "")
            {
                MessageBox.Show("Vui long nhap ten !","Thong Bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if(matKhau.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau","Thong Bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "select * from taiKhoan where TenTaiKhoan = '"+textBox_dn_tdangn.Text+"' and MatKhau = '"+textBox_dn_mk.Text+ "' ";
                if (modify.TaiKhoans(query).Count() > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong !", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                    this.Hide();    
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tai khoan hoac mat khau khong chin xac !", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
