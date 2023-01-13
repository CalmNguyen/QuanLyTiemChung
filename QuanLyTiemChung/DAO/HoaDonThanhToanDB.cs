using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class HoaDonThanhToanDB
    {
        public static string GetMaxMaHDTT()
        {
            string query = "select MAX(MaHDTT) from HoaDonThanhToan";
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
        public static bool ThemHDTT(BUS.HoaDonThanhToan hdtt)
        {
            string q = String.Format("insert into HoaDonThanhToan(MaHDTT, MaPDK, NgayLap, SoDotThanhToan, NgayThanhToanTiepTheo, PhuongThucGuiTien,LoaiThanhToan,ThanhTienMoiDot, TongTien, TongTienDaThanhToan, KhachHang) values(@MaHDTT, @MaPDK, @NgayLap, @SoDotThanhToan, @NgayTTTiepTheo, @PhuongThucGuiTien, @LoaiThanhToan, @ThanhTienMoiDot, @TongTien, @TongTienDaTT, @MaKH)");

            using (SqlConnection conn = Connect.Connection())
            {
              
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(q, conn);

                    cmd.Parameters.Add("@MaHDTT", SqlDbType.VarChar).Value = hdtt.getMaHDTT();
                    cmd.Parameters.Add("@MaPDK", SqlDbType.VarChar).Value = hdtt.getMaPDK();
                    cmd.Parameters.Add("@NgayLap", SqlDbType.Date).Value = hdtt.getNgayLap().ToShortDateString();
                    cmd.Parameters.Add("@SoDotThanhToan", SqlDbType.Int).Value = hdtt.getSoDotThanhToan();
                    cmd.Parameters.Add("@NgayTTTiepTheo", SqlDbType.Date).Value = hdtt.getNgayThanhToanTiepTheo().ToShortDateString();
                    cmd.Parameters.Add("@PhuongThucGuiTien", SqlDbType.NVarChar).Value = hdtt.getPhuongThucGuiTien();
                    cmd.Parameters.Add("@LoaiThanhToan", SqlDbType.NVarChar).Value = hdtt.getLoaiThanhToan();
                    cmd.Parameters.Add("@ThanhTienMoiDot", SqlDbType.Float).Value = hdtt.getThanhTienMoiDot();
                    cmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hdtt.getTongTien();
                    cmd.Parameters.Add("@TongTienDaTT", SqlDbType.Float).Value = hdtt.getTongTienDaThanhToan();
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hdtt.getKhachHang();
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
        public static DataTable layHDTTTheoMaHDTT(string mahdtt)
        {
            DataSet data = new DataSet();
            string query = "select * from HoaDonThanhToan where MaHDTT = '" + mahdtt + "'";
            
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(data);
                conn.Close();
            }
            return data.Tables[0];
        }
        public static bool updateHoaDonThanhToan_DaTT(string mahdtt, float tongTienDaTT)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "UPDATE HoaDonThanhToan SET TongTienDaThanhToan = '" + tongTienDaTT.ToString() + "' where MaHDTT = '" + mahdtt + "'";

                        command.ExecuteNonQuery();
                    }

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
