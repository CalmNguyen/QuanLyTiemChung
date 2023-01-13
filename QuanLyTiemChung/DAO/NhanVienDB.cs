using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class NhanVienDB
    {
        public static DataTable layViTri(BUS.NhanVien nv)
        {
            string query = "select ViTri from NhanVien where MaNV = '" + nv.getManv() + "' and Password = '" + nv.getPassword() + "'";
            DataSet data = new DataSet();
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(data);
                conn.Close();
            }

            return data.Tables[0];
        }
    }
}
