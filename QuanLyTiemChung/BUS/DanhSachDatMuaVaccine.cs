using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class DanhSachDatMuaVaccine
    {
        public static bool themDanhSachDatMuaVaccine(string makh, string tenvaccine, string soLuong)
        {
            return DAO.DanhSachDatMuaVaccineDB.themDanhSachDatMuaVaccine(makh, tenvaccine, soLuong);
        }
        public static DataTable layDSTheoTenVaccine_ChuaDuyet()
        {
            return DAO.DanhSachDatMuaVaccineDB.layDSTheoTenVaccine_ChuaDuyet();
        }
        public static bool duyetDanhSachDatMuaVaccine(string tenVaccine, string mapdh)
        {
           
            return DAO.DanhSachDatMuaVaccineDB.updateDanhSachDatMuaVaccine_MaPDH(tenVaccine, mapdh) && DAO.DanhSachDatMuaVaccineDB.updateDanhSachDatMuaVaccine(tenVaccine,"Da duoc duyet") ;
        }
        public static bool khongDuyetDanhSachDatMuaVaccine(string tenVaccine)
        {   
            return DAO.DanhSachDatMuaVaccineDB.updateDanhSachDatMuaVaccine(tenVaccine, "Khong duoc duyet");
        }
    }
}
