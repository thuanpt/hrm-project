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
    public partial class frmThongKeBaoCao : Form
    {
        public frmThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void frmThongKeBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btTKNhanSu_Click(object sender, EventArgs e)
        {
            frmReportNhanSu frm = new frmReportNhanSu();
            frm.ShowDialog();
        }

        private void btTKKhenThuong_Click(object sender, EventArgs e)
        {
            frmReportKhenThuong frm = new frmReportKhenThuong();
            frm.ShowDialog();
        }

        private void btTKKyLuat_Click(object sender, EventArgs e)
        {
            frmReportKyLuat frm = new frmReportKyLuat();
            frm.ShowDialog();
        }
    }
}
