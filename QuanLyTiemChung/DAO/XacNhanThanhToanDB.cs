using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyTiemChung.DAO
{
    class XacNhanThanhToanDB
    {
        public static string GetMaxMaXNTT()
        {
            string query = "select MAX(MaXNTT) from XacNhanThanhToan";
            DataSet data = new DataSet();
            string result = "";
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(data);
                result = data.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            return result;
        }
        public static bool ThemXNTT(BUS.XacNhanThanhToan xntt)
        {
            string q = String.Format("insert into XacNhanThanhToan (MaXNTT,MaHDTT,DotThanhToan,ThanhTien,NgayThanhToan,NgayThanhToanTiepTheo) values(@MaXNTT,@MaHDTT,@DotThanhToan,@ThanhTien,@NgayThanhToan,@NgayThanhToanTiepTheo)");

            using (SqlConnection conn = Connect.Connection())
            {

                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(q, conn);

                    cmd.Parameters.Add("@MaXNTT", SqlDbType.VarChar).Value = xntt.getMaXNTT();
                    cmd.Parameters.Add("@MaHDTT", SqlDbType.VarChar).Value = xntt.getMaHDTT();
                    cmd.Parameters.Add("@NgayThanhToan", SqlDbType.Date).Value = xntt.getNgayThanhToan().ToShortDateString();
                    cmd.Parameters.Add("@DotThanhToan", SqlDbType.Int).Value = xntt.getDotThanhToan();
                    cmd.Parameters.Add("@NgayThanhToanTiepTheo", SqlDbType.Date).Value = xntt.getNgayThanhToanTiepTheo().ToShortDateString();
                    cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = xntt.getThanhTien();
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    conn.Close();
                    return false;
                }

            }
        }
    }
    
}
