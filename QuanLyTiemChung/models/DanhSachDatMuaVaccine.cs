//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTiemChung.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DanhSachDatMuaVaccine")]
    public partial class DanhSachDatMuaVaccine
    {
        [Key]
        [ForeignKey("KhachHang")]
        public string MaKH { get; set; }
        public string TenVaccine { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string DuocDuyet { get; set; }
        [ForeignKey("PhieuDatHang")]
        public string MaPDH { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual PhieuDatHang PhieuDatHang { get; set; }
    }
}
