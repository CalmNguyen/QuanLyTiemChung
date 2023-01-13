namespace QuanLyTiemChung.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DanhSachCacGoiTiem", "Them", c => c.String());
            AddColumn("dbo.DanhSachCacGoiTiem", "Them1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DanhSachCacGoiTiem", "Them1");
            DropColumn("dbo.DanhSachCacGoiTiem", "Them");
        }
    }
}
