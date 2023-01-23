namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.power_supply")]
    public partial class power_supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public power_supply()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column("Id_ power_supply", TypeName = "uint")]
        public long Id__power_supply { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("Power_supply_ power")]
        public int Power_supply__power { get; set; }

        [Column("Power_supply_PCI-E")]
        public int Power_supply_PCI_E { get; set; }

        public int Price_rub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
