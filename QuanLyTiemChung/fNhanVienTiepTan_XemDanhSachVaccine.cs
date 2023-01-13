using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTiemChung
{
    public partial class fNhanVienTiepTan_XemDanhSachVaccine : Form
    {
        public fNhanVienTiepTan_XemDanhSachVaccine()
        {
            InitializeComponent();
        }

        private void fNhanVienTiepTan_XemDanhSachVaccine_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DanhSachVaccine";
            DataSet data = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connString))
            {
                conn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(data);
                conn.Close();
            }
            dataGridView1.DataSource = data.Tables[0];
        }
    }
}
