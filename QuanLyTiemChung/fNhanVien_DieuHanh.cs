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
    public partial class fNhanVien_DieuHanh : Form
    {
        public fNhanVien_DieuHanh()
        {
            InitializeComponent();
        }

        private void buttonXemLich_Click(object sender, EventArgs e)
        {
            fNhanVien_DieuHanh_XemLich f = new fNhanVien_DieuHanh_XemLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonXepLich_Click(object sender, EventArgs e)
        {
            fNhanVien_DieuHanh_SapXepLich f = new fNhanVien_DieuHanh_SapXepLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fNhanVien_DieuHanh_Load(object sender, EventArgs e)
        {

        }
    }
}
