namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuocTinh")]
    public partial class ThuocTinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThuocTinh()
        {
            HangHoas = new HashSet<HangHoa>();
        }

        [Key]
        public int MaThuocTinh { get; set; }

        [StringLength(50)]
        public string MauSac { get; set; }

        [StringLength(50)]
        public string KichThuoc { get; set; }

        [StringLength(300)]
        public string Khac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
}
