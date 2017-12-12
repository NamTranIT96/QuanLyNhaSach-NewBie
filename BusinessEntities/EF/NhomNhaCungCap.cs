namespace BusinessEntities.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomNhaCungCap")]
    public partial class NhomNhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomNhaCungCap()
        {
            NhaCungCaps = new HashSet<NhaCungCap>();
        }

        [Key]
        public int MaNhomNhaCC { get; set; }

        [StringLength(200)]
        public string TenNhomNhaCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhaCungCap> NhaCungCaps { get; set; }
    }
}
