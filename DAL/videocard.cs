namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.videocard")]
    public partial class videocard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public videocard()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_vga { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Video_frequency { get; set; }

        public int Memory_type { get; set; }

        public int Memory_frequency { get; set; }

        public int Video_memory { get; set; }

        public int Video_benchmark { get; set; }

        public int Power_supply_unit { get; set; }

        public int Video_length { get; set; }

        public int Price_rub { get; set; }

        public int Video_PCI_e { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
