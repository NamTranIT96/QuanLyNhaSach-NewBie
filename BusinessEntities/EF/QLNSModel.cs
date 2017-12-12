namespace BusinessEntities.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLNSModel : DbContext
    {
        public QLNSModel()
            : base("name=QLNSModel")
        {
        }

        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public virtual DbSet<HoaDonTraHang> HoaDonTraHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichSuThaoTac> LichSuThaoTacs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhomHang> NhomHangs { get; set; }
        public virtual DbSet<NhomKhachHang> NhomKhachHangs { get; set; }
        public virtual DbSet<NhomNhaCungCap> NhomNhaCungCaps { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<SanPhamPhieuNhapHang> SanPhamPhieuNhapHangs { get; set; }
        public virtual DbSet<ThongTinChiNhanh> ThongTinChiNhanhs { get; set; }
        public virtual DbSet<ThuocTinh> ThuocTinhs { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }
        public virtual DbSet<SanPhamHoaDon> SanPhamHoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiNhanh>()
                .HasMany(e => e.NguoiDungs)
                .WithOptional(e => e.ChiNhanh1)
                .HasForeignKey(e => e.ChiNhanh);

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.HangHoas)
                .WithOptional(e => e.DonViTinh1)
                .HasForeignKey(e => e.DonViTinh);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHangHoa)
                .IsFixedLength();

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.AnhDaiDien)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBanHang>()
                .Property(e => e.MaHoaDon_BanHang)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonBanHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonBanHang>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonTraHang>()
                .Property(e => e.MaHoaDon_TraHang)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonTraHang>()
                .Property(e => e.MaHoaDon_BanHang)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonTraHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonTraHang>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.AnhDaiDien)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.AnhDaiDien)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNhaCungCap)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<NhomHang>()
                .HasMany(e => e.HangHoas)
                .WithOptional(e => e.NhomHang1)
                .HasForeignKey(e => e.NhomHang);

            modelBuilder.Entity<NhomKhachHang>()
                .HasMany(e => e.KhachHangs)
                .WithOptional(e => e.NhomKhachHang)
                .HasForeignKey(e => e.Nhom);

            modelBuilder.Entity<NhomNhaCungCap>()
                .HasMany(e => e.NhaCungCaps)
                .WithOptional(e => e.NhomNhaCungCap)
                .HasForeignKey(e => e.NhomNhaCC);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaPhieuNhapHang)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaNhaCungCap)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength();

            modelBuilder.Entity<SanPhamPhieuNhapHang>()
                .Property(e => e.MaPhieuNhap)
                .IsFixedLength();

            modelBuilder.Entity<SanPhamPhieuNhapHang>()
                .Property(e => e.MaHangHoa)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinChiNhanh>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinChiNhanh>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<ThuocTinh>()
                .HasMany(e => e.HangHoas)
                .WithOptional(e => e.ThuocTinh1)
                .HasForeignKey(e => e.ThuocTinh);

            modelBuilder.Entity<VaiTro>()
                .HasMany(e => e.NguoiDungs)
                .WithOptional(e => e.VaiTro1)
                .HasForeignKey(e => e.VaiTro);

            modelBuilder.Entity<SanPhamHoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength();

            modelBuilder.Entity<SanPhamHoaDon>()
                .Property(e => e.MaHangHoa)
                .IsFixedLength();
        }
    }
}
