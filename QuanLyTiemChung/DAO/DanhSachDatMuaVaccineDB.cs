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

namespace QuanLyTiemChung.DAO
{
    class DanhSachDatMuaVaccineDB
    {
        public static bool themDanhSachDatMuaVaccine(string makh, string tenvaccine, string soLuong)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;            
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into DanhSachDatMuaVaccine(MaKH,TenVaccine, SoLuong, DuocDuyet) VALUES (@makh, @tenvaccine, "+ soLuong +", N'Chua duoc duyet')";
                        command.Parameters.AddWithValue("@makh", makh);
                        command.Parameters.AddWithValue("@tenvaccine", tenvaccine);
                        
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
        public static bool updateDanhSachDatMuaVaccine(string tenVaccine, string duocDuyet)
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
                        command.CommandText = "UPDATE DanhSachDatMuaVaccine SET DuocDuyet = N'"+ duocDuyet +"' WHERE  TenVaccine = '" + tenVaccine +"' and DuocDuyet = N'Chua duoc duyet'";
                       
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
        public static bool updateDanhSachDatMuaVaccine_MaPDH(string tenVaccine, string mapdh)
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
                        command.CommandText = "UPDATE DanhSachDatMuaVaccine SET MaPDH = '" +  mapdh +"' WHERE  TenVaccine = '" + tenVaccine + "' and DuocDuyet = N'Chua duoc duyet'";
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
        public static DataTable layDSTheoTenVaccine_ChuaDuyet()
        {
            string query = "select TenVaccine, sum(SoLuong) as SoLuong from DanhSachDatMuaVaccine where DuocDuyet = N'Chua duoc duyet' group by TenVaccine";
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
