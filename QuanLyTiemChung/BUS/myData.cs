using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace QuanLyTiemChung.BUS
{
    public class MyData : DbContext
    {
        DbSet<DanhSachCacGoiTiem> DanhSachCacGoiTiems { get; set; }
        //DbSet<PhieuDangKi> PhieuDangKy { get; set; }
        public MyData() : base("AutomatedMigration")
        {
            /*var initializer = new MigrateDatabaseToLatestVersion<MyData, Migrations.Configuration>();
            Database.SetInitializer(initializer);*/
        }
    }
}
