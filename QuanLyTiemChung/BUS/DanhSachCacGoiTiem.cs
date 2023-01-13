using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTiemChung.BUS
{

    //[Table("DanhSachCacGoiTiem")]
    class DanhSachCacGoiTiem
    {
        [Key]
        public string MaGoiVaccine { get; set; }
        public string TenVaccine { get; set; }
        /*public string GhiChu { set; get; }
        public string ThemCot { set; get; }
        public string ThemCot1 { set; get; }*/
        public static DataTable layAllDanhSachCacGoiTiem()
        {
            return DAO.DanhSachCacGoiTiemDB.layAllDanhSachCacGoiTiem();
        }
    }
}
