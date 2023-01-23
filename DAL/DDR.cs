namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.DDR")]
    public partial class DDR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DDR()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_DDR { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int DDR_type { get; set; }

        public int DDR_frenquency { get; set; }

        public int DDR_quantity { get; set; }

        public int DDR_size { get; set; }

        public int DDR_rub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
