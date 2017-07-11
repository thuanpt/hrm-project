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
    public partial class frmKyLuat : Form
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }

        KyLuatBUS kyluatbus = new KyLuatBUS();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaKL.Text == "" || txtMaNS.Text == "" || txtNoiDungKL.Text == "")
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            else
            {
                if (kyluatbus.KTTonTai(txtMaKL.Text) == true)
                    MessageBox.Show("Mã KL đã tồn tại", "Thông báo");
                else
                {
                    kyluatbus.ThemKyLuat(txtMaKL.Text, txtMaNS.Text, dtNgayKL.Value, txtNoiDungKL.Text);
                    dgvKyLuat.DataSource = kyluatbus.viewKyLuat();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;

            txtMaKL.Enabled = false;
            txtMaNS.Enabled = true;
            dtNgayKL.Enabled = true;
            txtNoiDungKL.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            kyluatbus.XoaKyLuat(txtMaKL.Text);
            dgvKyLuat.DataSource = kyluatbus.viewKyLuat();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            kyluatbus.SuaKyLuat(txtMaKL.Text, txtMaNS.Text, dtNgayKL.Value, txtNoiDungKL.Text);
            dgvKyLuat.DataSource = kyluatbus.viewKyLuat();
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKL.Enabled = true;
            txtMaNS.Enabled = true;
            dtNgayKL.Enabled = true;
            txtNoiDungKL.Enabled = true;

            txtMaKL.Text = "";
            txtMaNS.Text = "";
            txtNoiDungKL.Text = "";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
            btThem.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dgvKyLuat_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvKyLuat.SelectedRows[0];
            txtMaKL.Text = dr.Cells["MaKyLuat"].Value.ToString();
            txtMaNS.Text = dr.Cells["MaNhanSu"].Value.ToString();
            dtNgayKL.Text = dr.Cells["NgayKL"].Value.ToString();
            txtNoiDungKL.Text = dr.Cells["NoiDungKL"].Value.ToString();

            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
            txtMaKL.Enabled = false;
            txtMaNS.Enabled = false;
            txtNoiDungKL.Enabled = false;
        }

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            dgvKyLuat.DataSource = kyluatbus.viewKyLuat();

            dgvKyLuat.Columns["MaKyLuat"].Width = 120;
            dgvKyLuat.Columns["MaNhanSu"].Width = 120;

            dgvKyLuat.Columns["MaKyLuat"].HeaderText = "Mã Kỷ Luật";
            dgvKyLuat.Columns["MaNhanSu"].HeaderText = "Mã Nhân Sự";
            dgvKyLuat.Columns["NgayKL"].HeaderText = "Ngày KL";
            dgvKyLuat.Columns["NoiDungKL"].HeaderText = "Nội dung";
        }
    }
}
