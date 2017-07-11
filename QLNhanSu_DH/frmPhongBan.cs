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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            phongbanbus.XoaPhongBan(txtMaPhongBan.Text);
            dgvPhongBan.DataSource = phongbanbus.viewPhongBan();
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        PhongBanBUS phongbanbus = new PhongBanBUS();
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            dgvPhongBan.DataSource = phongbanbus.viewPhongBan();

            dgvPhongBan.Columns["MaPhongBan"].Width = 161;
            dgvPhongBan.Columns["TenPhongBan"].Width = 170;

            dgvPhongBan.Columns["MaPhongBan"].HeaderText = "Mã Phòng Ban";
            dgvPhongBan.Columns["TenPhongBan"].HeaderText = "Tên Phòng Ban";
            dgvPhongBan.Columns["GhiChu"].HeaderText = "Ghi chú";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text == "" || txtTenPhongBan.Text == "")
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            else
            {
                if (phongbanbus.KTTonTai(txtMaPhongBan.Text) == true)
                    MessageBox.Show("Mã Phòng Ban đã tồn tại", "Thông báo");
                else
                {
                    phongbanbus.ThemPhongBan(txtMaPhongBan.Text, txtTenPhongBan.Text, txtGhiChu.Text);
                    dgvPhongBan.DataSource = phongbanbus.viewPhongBan();
                }
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
            
            txtMaPhongBan.Enabled = false;
            txtTenPhongBan.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            phongbanbus.SuaPhongBan(txtMaPhongBan.Text, txtTenPhongBan.Text, txtGhiChu.Text);
            dgvPhongBan.DataSource = phongbanbus.viewPhongBan();
        }

        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhongBan.SelectedRows[0];
            txtMaPhongBan.Text = dr.Cells["MaPhongBan"].Value.ToString();
            txtTenPhongBan.Text = dr.Cells["TenPhongBan"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();

            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
            txtMaPhongBan.Enabled = false;
            txtTenPhongBan.Enabled = false;
            txtGhiChu.Enabled = false;

        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhongBan.Enabled = true;
            txtTenPhongBan.Enabled = true;
            txtGhiChu.Enabled = true;

            txtMaPhongBan.Text = "";
            txtTenPhongBan.Text = "";
            txtGhiChu.Text = "";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
            btThem.Enabled = true;
        }
    }
}
