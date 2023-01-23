namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.SSD")]
    public partial class SSD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SSD()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_SSD { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(12)]
        public string Form_factor { get; set; }

        public int Price_rub { get; set; }

        public int SSD_connection_interface { get; set; }

        public int SSD_read_speed { get; set; }

        public int SSD_write_speed { get; set; }

        public int SSD_volume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
