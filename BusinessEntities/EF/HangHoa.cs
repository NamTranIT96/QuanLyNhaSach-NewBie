namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [Key]
        [StringLength(10)]
        public string MaHangHoa { get; set; }

        [StringLength(200)]
        public string TenHang { get; set; }

        public int? NhomHang { get; set; }

        public double? GiaBan { get; set; }

        public double? GiaVon { get; set; }

        public int? TonKho { get; set; }

        [StringLength(500)]
        public string AnhDaiDien { get; set; }

        public int? DonViTinh { get; set; }

        public int? ThuocTinh { get; set; }

        [StringLength(50)]
        public string MaBarCode { get; set; }

        public virtual DonViTinh DonViTinh1 { get; set; }

        public virtual NhomHang NhomHang1 { get; set; }

        public virtual ThuocTinh ThuocTinh1 { get; set; }
    }
}
