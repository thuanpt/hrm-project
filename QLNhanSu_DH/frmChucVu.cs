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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chucvubus.SuaChucVu(txtMaChucVu.Text, txtTenCV.Text);
            dgvChucVu.DataSource = chucvubus.viewChucVu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chucvubus.XoaChucVu(txtMaChucVu.Text);
            dgvChucVu.DataSource = chucvubus.viewChucVu();
        }
        ChucVuBUS chucvubus = new ChucVuBUS();
        private void btThem_Click(object sender, EventArgs e)
        {       

            if (txtMaChucVu.Text == "" || txtTenCV.Text == "")
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            else
            {
                if (chucvubus.KTTonTai(txtMaChucVu.Text) == true)
                    MessageBox.Show("Mã Phòng Ban đã tồn tại", "Thông báo");
                else
                {
                    chucvubus.ThemChucVu(txtMaChucVu.Text, txtTenCV.Text);
                    dgvChucVu.DataSource = chucvubus.viewChucVu();
                }
            }
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            dgvChucVu.DataSource = chucvubus.viewChucVu();

            dgvChucVu.Columns["MaCV"].Width = 161;
            dgvChucVu.Columns["TenCV"].Width = 170;

            dgvChucVu.Columns["MaCV"].HeaderText = "Mã Chức Vụ";
            dgvChucVu.Columns["TenCV"].HeaderText = "Tên Chức Vụ";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaChucVu.Enabled = true;
            txtTenCV.Enabled = true;

            txtMaChucVu.Text = "";
            txtTenCV.Text = "";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
            btThem.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;

            txtMaChucVu.Enabled = false;
            txtTenCV.Enabled = true;
            
        }

        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvChucVu.SelectedRows[0];
            txtMaChucVu.Text = dr.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = dr.Cells["TenCV"].Value.ToString();

            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
            txtMaChucVu.Enabled = false;
            txtTenCV.Enabled = false;

        }
    }
}
