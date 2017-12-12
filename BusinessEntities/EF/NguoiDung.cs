namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        [StringLength(200)]
        public string TenNguoiDung { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        public string MatKhau { get; set; }

        public int? VaiTro { get; set; }

        public int? ChiNhanh { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string KhuVuc { get; set; }

        [StringLength(200)]
        public string PhuongXa { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(500)]
        public string AnhDaiDien { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        public virtual ChiNhanh ChiNhanh1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }

        public virtual VaiTro VaiTro1 { get; set; }
    }
}
