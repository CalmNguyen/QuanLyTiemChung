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
    public partial class fQuanLy_DuyetDSDM : Form
    {
        public fQuanLy_DuyetDSDM()
        {
            InitializeComponent();
        }

        private void fQuanLy_DuyetDSDM_Load(object sender, EventArgs e)
        {
            dataGridViewVaccineDM_Load();
        }
        private void dataGridViewVaccineDM_Load()
        {
            dataGridViewVaccineDM.DataSource = BUS.DanhSachDatMuaVaccine.layDSTheoTenVaccine_ChuaDuyet();
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            BUS.PhieuDatHang pdh = new BUS.PhieuDatHang(dataGridViewVaccineDM.CurrentRow.Cells["SoLuong"].Value.ToString(),
                                                       textBoxNhaCungCap.Text,
                                                       dataGridViewVaccineDM.CurrentRow.Cells["TenVaccine"].Value.ToString());

            bool isTrue = pdh.ThemPDH() && BUS.DanhSachDatMuaVaccine.duyetDanhSachDatMuaVaccine(dataGridViewVaccineDM.CurrentRow.Cells["TenVaccine"].Value.ToString(), pdh.getMaPDH());

            if (isTrue)
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            dataGridViewVaccineDM_Load();
        }

        private void buttonKhongDuyet_Click(object sender, EventArgs e)
        {
            bool isTrue = BUS.DanhSachDatMuaVaccine.khongDuyetDanhSachDatMuaVaccine(dataGridViewVaccineDM.CurrentRow.Cells["TenVaccine"].Value.ToString());

            if (isTrue)
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            dataGridViewVaccineDM_Load();
        }
    }
}
