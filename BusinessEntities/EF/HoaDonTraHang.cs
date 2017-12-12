namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonTraHang")]
    public partial class HoaDonTraHang
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDon_TraHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHoaDon_BanHang { get; set; }

        [StringLength(10)]
        public string MaKhachHang { get; set; }

        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        public DateTime? NgayGio { get; set; }

        public double? ThanhTien { get; set; }

        public double? PhiTraHang { get; set; }

        public double? TienTraLaiKhach { get; set; }
    }
}
