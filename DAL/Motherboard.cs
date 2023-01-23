namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.Motherboard")]
    public partial class Motherboard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motherboard()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_mboard { get; set; }

        [Required]
        [StringLength(30)]
        public string Mboard_size { get; set; }

        public int Mboard_DDR { get; set; }

        public int Mboard_max_DDR { get; set; }

        public int Mboard_max_frenquency_DDR { get; set; }

        public int Price_rub { get; set; }

        [Required]
        [StringLength(20)]
        public string Mboard_socket { get; set; }

        public int? Mboard_M2 { get; set; }

        public int Mboard_Sata_III { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
