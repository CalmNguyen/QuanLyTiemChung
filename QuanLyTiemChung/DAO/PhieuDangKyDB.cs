using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class PhieuDangKyDB
    {
        public static bool themPhieuDangKy(BUS.PhieuDangKi pdk)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into PhieuDangKy(MaPDK, NgayLap, GoiVaccine, NgayTiem, NVGhiNhan, MaKH) VALUES (@MaPDK, @NgayLap, @GoiVaccine, @NgayTiem, @NVGhiNhan, @MaKH)";
                        command.Parameters.AddWithValue("@MaPDK", pdk.getMapdk());
                        command.Parameters.AddWithValue("@NgayLap", pdk.getNgayLap());
                        command.Parameters.AddWithValue("@GoiVaccine", pdk.getGoiVaccine());
                        command.Parameters.AddWithValue("@NgayTiem", pdk.getNgayTiem());
                        command.Parameters.AddWithValue("@NVGhiNhan", pdk.getNvGhiNhan());
                        command.Parameters.AddWithValue("@MaKH", pdk.getMakh());
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
        public static DataTable layAllPhieuDangKy()
        {
            string query = "select * from PhieuDangKy";
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
