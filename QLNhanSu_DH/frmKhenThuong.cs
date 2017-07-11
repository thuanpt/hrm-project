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
    public partial class frmKhenThuong : Form
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaKT.Text == "" || txtMaNS.Text == ""|| txtNoiDungKT.Text =="")
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            else
            {
                if (khenthuongbus.KTTonTai(txtMaKT.Text) == true)
                    MessageBox.Show("Mã khen thưởng đã tồn tại", "Thông báo");
                else
                {
                    khenthuongbus.ThemKhenThuong(txtMaKT.Text, txtMaNS.Text, dtNgayKT.Value,txtNoiDungKT.Text);
                    dgvKhenThuong.DataSource = khenthuongbus.viewKhenThuong();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;

            txtMaKT.Enabled = false;
            txtMaNS.Enabled = true;
            dtNgayKT.Enabled = true;
            txtNoiDungKT.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            khenthuongbus.XoaKhenThuong(txtMaKT.Text);
            dgvKhenThuong.DataSource = khenthuongbus.viewKhenThuong();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            khenthuongbus.SuaKhenThuong(txtMaKT.Text, txtMaNS.Text,dtNgayKT.Value, txtNoiDungKT.Text);
            dgvKhenThuong.DataSource = khenthuongbus.viewKhenThuong();
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKT.Enabled = true;
            txtMaNS.Enabled = true;
            dtNgayKT.Enabled = true;
            txtNoiDungKT.Enabled = true;

            txtMaKT.Text = "";
            txtMaNS.Text = "";
            txtNoiDungKT.Text = "";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
            btThem.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void lbTenNS_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        KhenThuongBUS khenthuongbus = new KhenThuongBUS();
        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            dgvKhenThuong.DataSource = khenthuongbus.viewKhenThuong();

            dgvKhenThuong.Columns["MaKhenThuong"].Width = 120;
            dgvKhenThuong.Columns["MaNhanSu"].Width = 120;

            dgvKhenThuong.Columns["MaKhenThuong"].HeaderText = "Mã Khen Thưởng";
            dgvKhenThuong.Columns["MaNhanSu"].HeaderText = "Mã Nhân Sự";
            dgvKhenThuong.Columns["NgayKT"].HeaderText = "Ngày KT";
            dgvKhenThuong.Columns["NoiDungKT"].HeaderText = "Nội dung";
        }

        private void dgvKhenThuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvKhenThuong.SelectedRows[0];
            txtMaKT.Text = dr.Cells["MaKhenThuong"].Value.ToString();
            txtMaNS.Text = dr.Cells["MaNhanSu"].Value.ToString();
            dtNgayKT.Text = dr.Cells["NgayKT"].Value.ToString();
            txtNoiDungKT.Text = dr.Cells["NoiDungKT"].Value.ToString();

            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
            txtMaKT.Enabled = false;
            txtMaNS.Enabled = false;
            txtNoiDungKT.Enabled = false;
        }
    }
}
