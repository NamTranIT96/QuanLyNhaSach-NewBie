namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapHang")]
    public partial class PhieuNhapHang
    {
        [Key]
        [StringLength(10)]
        public string MaPhieuNhapHang { get; set; }

        [StringLength(10)]
        public string MaNhaCungCap { get; set; }

        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        public DateTime? NgayGio { get; set; }

        public double? TongTienHang { get; set; }

        public double? GiamGia { get; set; }

        public double? CanTraNhaCungCap { get; set; }

        public double? TienTraNhaCungCap { get; set; }

        public double? TienThua { get; set; }
    }
}
