using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNhanSu_DH
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btNhanSu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmHoSoNV frm = new frmHoSoNV();
            frm.Show();
        }

        private void btPhongBan_Click(object sender, EventArgs e)
        {

            //this.Hide();
            frmPhongBan frm = new frmPhongBan();
            frm.Show();
        }

        private void btChucVu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmChucVu frm = new frmChucVu();
            frm.Show();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmThongKeBaoCao frm = new frmThongKeBaoCao();
            frm.Show();
        }

        private void btKhenThuong_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmKhenThuong frm = new frmKhenThuong();
            frm.Show();
        }

        private void btKyLuat_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmKyLuat frm = new frmKyLuat();
            frm.Show();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmTimKiem frm = new frmTimKiem();
            frm.Show();
        }

        private void btDanToc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDanToc frm = new frmDanToc();
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void lbDoiMK_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }
    }
}
