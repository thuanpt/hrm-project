using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLNhanSu_DH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (taikhoanbus.KTDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
                this.Hide();
                frmMenu frm = new frmMenu();
                frm.Show();
            }
            else
                MessageBox.Show( "Tài khoản hoặc mật khẩu không đúng", "Thông báo");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
