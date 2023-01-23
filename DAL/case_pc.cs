namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.case_pc")]
    public partial class case_pc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public case_pc()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_case { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Max_height_cooler { get; set; }

        public int? Integrated_power_supply { get; set; }

        public int Max_length_video { get; set; }

        public int Price_rub { get; set; }

        public int? Form_factor_2_5 { get; set; }

        public int? Form_factor_3_5 { get; set; }

        [Required]
        [StringLength(30)]
        public string Form_factor_mboard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
