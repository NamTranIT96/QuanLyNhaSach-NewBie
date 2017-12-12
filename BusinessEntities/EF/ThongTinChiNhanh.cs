namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinChiNhanh")]
    public partial class ThongTinChiNhanh
    {
        [Key]
        public int STT { get; set; }

        public int? MaChiNhanh { get; set; }

        [StringLength(200)]
        public string TenCuaHang { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string KhuVuc { get; set; }

        [StringLength(100)]
        public string PhuongXa { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string NgonNgu { get; set; }

        [StringLength(500)]
        public string Logo { get; set; }
    }
}
