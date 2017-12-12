namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPhamPhieuNhapHang")]
    public partial class SanPhamPhieuNhapHang
    {
        [Key]
        public int STT { get; set; }

        [StringLength(10)]
        public string MaPhieuNhap { get; set; }

        [StringLength(10)]
        public string MaHangHoa { get; set; }

        [StringLength(200)]
        public string TenHang { get; set; }

        public int? SoLuong { get; set; }

        public double? TongTien { get; set; }
    }
}
