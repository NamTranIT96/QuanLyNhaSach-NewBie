namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhachHang { get; set; }

        [StringLength(100)]
        public string TenKhachHang { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string KhuVuc { get; set; }

        [StringLength(100)]
        public string PhuongXa { get; set; }

        [StringLength(100)]
        public string MaSoThue { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? Nhom { get; set; }

        [StringLength(500)]
        public string Ghichu { get; set; }

        [StringLength(500)]
        public string AnhDaiDien { get; set; }

        public double? TichDiem { get; set; }

        public double? TongTienMua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }

        public virtual NhomKhachHang NhomKhachHang { get; set; }
    }
}
