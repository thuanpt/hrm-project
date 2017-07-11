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
    public partial class frmReportNhanSu : Form
    {
        public frmReportNhanSu()
        {
            InitializeComponent();
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {
            NhanSuBUS nhansubus = new NhanSuBUS();
            HoSoNhanSuBindingSource.DataSource = nhansubus.viewNhanSu();
            this.reportViewer1.RefreshReport();
        }
    }
}
