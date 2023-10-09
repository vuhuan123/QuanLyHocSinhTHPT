using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hoc_Sinh_THPT
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        public bool checkAcount(string ac)
        {

            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string email) {

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        Modify modify = new Modify();

        private void DangKy_Load(object sender, EventArgs e)
        {
            


        }

        private void button_dangky_Click(object sender, EventArgs e)
        {
            string tenTK = textBox_ttk.Text;
            string mK = textBox_dk_mk.Text;
            string xacNhanMK = textBox_xnmk.Text;
            string email = textBox_email.Text;
            if (!checkAcount(tenTK))
            {
                MessageBox.Show("Vui long nhap ten tai khoan dai 6-24 ky tu, voi cac ky tu chu va so, chu hoa va thuong", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            if (!checkAcount(mK))
            {
                MessageBox.Show("Vui long nhap mat khau dai 6-24 ky tu, voi cac ky tu chu va so, chu hoa va thuong", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (xacNhanMK != mK)
            {
                MessageBox.Show("Vui long nhap lai mat khau", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui long nhap dung dinh dang email", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                return;
            }
            if (modify.TaiKhoans("Select * from taiKhoan where Email = '"+email+"'").Count != 0)
            {

                MessageBox.Show("Email nay da duoc dang ky","Thong Bao",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            try
            {
                string query = "insert into taiKhoan values('"+tenTK+"', '"+mK+"', '"+email+"')";
                modify.Command(query);
                if(MessageBox.Show("Dang ky thanh cong! Ban co muon dang nhap luon khong?","Thong Bao", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            catch {
                MessageBox.Show("Ten tai khoan nay da duoc dang ky, vui long dang ky lai","Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
            }
        }
    }
}
