namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [Key]
        [StringLength(10)]
        public string MaNhaCungCap { get; set; }

        [StringLength(200)]
        public string TenNhaCungCap { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string KhuVuc { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string CongTy { get; set; }

        public int? NhomNhaCC { get; set; }

        [StringLength(500)]
        public string Logo { get; set; }

        public virtual NhomNhaCungCap NhomNhaCungCap { get; set; }
    }
}
