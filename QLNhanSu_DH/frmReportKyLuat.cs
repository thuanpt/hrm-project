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
    public partial class frmReportKyLuat : Form
    {
        public frmReportKyLuat()
        {
            InitializeComponent();
        }

        private void frmReportKyLuat_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
