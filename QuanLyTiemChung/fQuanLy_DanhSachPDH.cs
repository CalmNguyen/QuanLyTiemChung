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
    public partial class fQuanLy_DanhSachPDH : Form
    {
        public fQuanLy_DanhSachPDH()
        {
            InitializeComponent();
        }

        private void fQuanLy_DanhSachPDH_Load(object sender, EventArgs e)
        {
            dataGridViewDSPDH_Load();
        }

        private void dataGridViewDSPDH_Load()
        {
            dataGridViewDSPDH.DataSource = BUS.PhieuDatHang.layAllPhieuDatHang();
        }

    }
}
