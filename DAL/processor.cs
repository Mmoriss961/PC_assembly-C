namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("f0441836_servis_bd.processor")]
    public partial class processor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public processor()
        {
            Pc_assembly = new HashSet<Pc_assembly>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long Id_proc { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(12)]
        public string Socket { get; set; }

        public int Number_cores { get; set; }

        public int Proc_Frequency { get; set; }

        public int Price_rub { get; set; }

        public int TDP { get; set; }

        public int Proc_benchmark { get; set; }

        public int Proc_max_frenquency_DDR { get; set; }

        public int Proc_DDR { get; set; }

        public int Proc_max_syze_DDR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pc_assembly> Pc_assembly { get; set; }
    }
}
