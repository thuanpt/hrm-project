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
    public partial class frmDanToc : Form
    {
        public frmDanToc()
        {
            InitializeComponent();
        }
        DanTocBUS dantocbus = new DanTocBUS();
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = dantocbus.viewDanToc();

            dgvDanToc.Columns["MaDanToc"].Width = 161;
            dgvDanToc.Columns["TenDanToc"].Width = 170;

            dgvDanToc.Columns["MaDanToc"].HeaderText = "Mã Dân Tộc";
            dgvDanToc.Columns["TenDanToc"].HeaderText = "Tên Dân Tộc";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaDanToc.Text == "" || txtTenDT.Text == "")
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            else
            {
                if (dantocbus.KTTonTai(txtMaDanToc.Text) == true)
                    MessageBox.Show("Mã Dân Tộc đã tồn tại", "Thông báo");
                else
                {
                    dantocbus.ThemDanToc(txtMaDanToc.Text, txtTenDT.Text);
                    dgvDanToc.DataSource = dantocbus.viewDanToc();
                }
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDT.Enabled = true;
            txtMaDanToc.Enabled = true;

            txtMaDanToc.Text = "";
            txtTenDT.Text = "";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
            btThem.Enabled = true;
        }

        private void dgvDanToc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanToc.SelectedRows[0];
            txtMaDanToc.Text = dr.Cells["MadanToc"].Value.ToString();
            txtTenDT.Text = dr.Cells["TenDanToc"].Value.ToString();

            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
            txtMaDanToc.Enabled = false;
            txtTenDT.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;

            txtMaDanToc.Enabled = false;
            txtTenDT.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            dantocbus.XoaDanToc(txtMaDanToc.Text);
            dgvDanToc.DataSource = dantocbus.viewDanToc();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            dantocbus.SuaDanToc(txtMaDanToc.Text, txtTenDT.Text);
            dgvDanToc.DataSource = dantocbus.viewDanToc();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
