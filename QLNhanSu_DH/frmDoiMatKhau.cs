using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QLNhanSu_DH
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text == "" || txtMKMoi.Text == "" || txtNhapLaiMK.Text =="")
                MessageBox.Show("Bạn chưa nhập Mật khẩu cũ hoặc chưa nhập và xác nhận lại mật khẩu mới!");
            else if (this.txtMKMoi.TextLength != this.txtNhapLaiMK.TextLength) MessageBox.Show("Mật khẩu mới chưa trùng");
            else
            {
                if (taikhoanbus.KTDoiMatKhau("admin", txtMKCu.Text) == false)
                    MessageBox.Show("Mật khẩu cũ chưa đúng!", "Thông báo");
                else
                {


                    taikhoanbus.DoiMatKhau("admin", txtMKMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                
            }
        }
      }
}

