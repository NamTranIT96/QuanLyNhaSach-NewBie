namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonBanHang")]
    public partial class HoaDonBanHang
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDon_BanHang { get; set; }

        [StringLength(10)]
        public string MaKhachHang { get; set; }

        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        public DateTime? NgayGio { get; set; }

        public double? TongTien { get; set; }

        public double? ChietKhau { get; set; }

        public double? TongCong { get; set; }

        public bool? Status { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
