namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuThaoTac")]
    public partial class LichSuThaoTac
    {
        [Key]
        public int STT { get; set; }

        [StringLength(200)]
        public string TenNhanVien { get; set; }

        [StringLength(200)]
        public string ChucNang { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(1000)]
        public string NoiDung { get; set; }
    }
}
