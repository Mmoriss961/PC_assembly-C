namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.Pc_assembly")]
    public partial class Pc_assembly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pc_assembly()
        {
            DDR = new HashSet<DDR>();
            HDD = new HashSet<HDD>();
            SSD = new HashSet<SSD>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_Pc_assembly { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_user { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_cooler { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_case_pc { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_motherboard { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_power_supply { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_processor { get; set; }

        [Column(TypeName = "uint")]
        public long? Id_vga { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Time_Assembly { get; set; }
            
        public int? Price_end { get; set; }

        public virtual case_pc case_pc { get; set; }

        public virtual cooler cooler { get; set; }

        public virtual Motherboard Motherboard { get; set; }

        public virtual users users { get; set; }

        public virtual processor processor { get; set; }

        public virtual videocard videocard { get; set; }

        public virtual power_supply power_supply { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDR> DDR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDD> HDD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SSD> SSD { get; set; }
    }
}
