using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class PhieuDatHangDB
    {
        public static DataTable layAllPhieuDatHang()
        {
            string query = "select * from PhieuDatHang";
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

        public static bool ThemPDH(BUS.PhieuDatHang pdh)
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
                        command.CommandText = "INSERT INTO PhieuDatHang(MaPDH, NgayLap, NhaCungCap, TongSoLuongDatMua, TenVaccine) VALUES (@MaPDH, @NgayLap, @NhaCungCap, @TongSoLuongDatMua, @TenVaccine);";
                        command.Parameters.Add("@MaPDH", pdh.getMaPDH());
                        command.Parameters.Add("@Ngaylap", SqlDbType.Date).Value = DateTime.Now;
                        command.Parameters.Add("@NhaCungCap", pdh.getNhaCungCap());
                        command.Parameters.Add("@TongSoLuongDatMua", pdh.getSoLuongDatMua());
                        command.Parameters.Add("@TenVaccine", pdh.getTenVaccine());
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
