﻿//------------------------------------------------------------------------------
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

    [Table("DanhSachCacGoiTiem")]
    public partial class DanhSachCacGoiTiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhSachCacGoiTiem()
        {
            this.PhieuDangKies = new HashSet<PhieuDangKy>();
        }
        [Key]
        public string MaGoiVaccine { get; set; }
        public string TenVaccine { get; set; }
        public string GhiChu { get; set; }
        //thêm cột mới 
        public string Them { get; set; }
        public string Them1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDangKy> PhieuDangKies { get; set; }
    }
}