using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void buttonDSPDH_Click(object sender, EventArgs e)
        {
            fQuanLy_DanhSachPDH f = new fQuanLy_DanhSachPDH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonDSDMVC_Click(object sender, EventArgs e)
        {
            fQuanLy_DuyetDSDM f = new fQuanLy_DuyetDSDM();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
