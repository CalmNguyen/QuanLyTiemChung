using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public partial class fNhanVien_TiepTan_XemDanhSachVaccine : Form
    {
        public fNhanVien_TiepTan_XemDanhSachVaccine()
        {
            InitializeComponent();
        }

        private void fNhanVien_TiepTan_XemDanhSachVaccine_Load(object sender, EventArgs e)
        {
            dataGridViewGoiVaccine.DataSource = BUS.DanhSachCacGoiTiem.layAllDanhSachCacGoiTiem();
        }
    }
}
