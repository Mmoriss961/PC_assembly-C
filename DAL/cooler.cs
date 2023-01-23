namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.cooler")]
    public partial class cooler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cooler()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column("Id_cooler", TypeName = "uint")]
        public long Id_cooler { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Cooler_height { get; set; }

        public int Cooler_Max_TDP { get; set; }

        [Required]
        [StringLength(20)]
        public string Cooler_Socket { get; set; }

        public int Price_rub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
