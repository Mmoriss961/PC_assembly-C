namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<case_pc> case_pc { get; set; }
        public virtual DbSet<cooler> cooler { get; set; }
        public virtual DbSet<DDR> DDR { get; set; }
        public virtual DbSet<HDD> HDD { get; set; }
        public virtual DbSet<Motherboard> Motherboard { get; set; }
        public virtual DbSet<Pc_assembly> Pc_assembly { get; set; }
        public virtual DbSet<power_supply> power_supply { get; set; }
        public virtual DbSet<processor> processor { get; set; }
        public virtual DbSet<SSD> SSD { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<videocard> videocard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<case_pc>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<case_pc>()
                .Property(e => e.Form_factor_mboard)
                .IsUnicode(false);

            modelBuilder.Entity<case_pc>()
                .HasMany(e => e.Pc_assembly)
                .WithRequired(e => e.case_pc)
                .HasForeignKey(e => e.Id_case_pc);

            modelBuilder.Entity<cooler>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<cooler>()
                .Property(e => e.Cooler_Socket)
                .IsUnicode(false);

            modelBuilder.Entity<cooler>()
                .HasMany(e => e.Pc_assembly)
                .WithRequired(e => e.cooler)
                .HasForeignKey(e => e.Id_cooler);

            modelBuilder.Entity<DDR>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DDR>()
                .HasMany(e => e.Pc_assembly)
                .WithMany(e => e.DDR)
                .Map(m => m.ToTable("Pc_assembly_DDR").MapLeftKey("Id_DDR").MapRightKey("Id_Pc_assembly"));

            modelBuilder.Entity<HDD>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<HDD>()
                .HasMany(e => e.Pc_assembly)
                .WithMany(e => e.HDD)
                .Map(m => m.ToTable("Pc_assembly_HDD").MapLeftKey("Id_HDD").MapRightKey("Id_Pc_assembly"));

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Mboard_size)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Mboard_socket)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .HasMany(e => e.Pc_assembly)
                .WithRequired(e => e.Motherboard)
                .HasForeignKey(e => e.Id_motherboard);

            modelBuilder.Entity<power_supply>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<power_supply>()
                .HasMany(e => e.Pc_assembly)
                .WithRequired(e => e.power_supply)
                .HasForeignKey(e => e.Id_power_supply)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<processor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<processor>()
                .Property(e => e.Socket)
                .IsUnicode(false);

            modelBuilder.Entity<processor>()
                .HasMany(e => e.Pc_assembly)
                .WithRequired(e => e.processor)
                .HasForeignKey(e => e.Id_processor);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Form_factor)
                .IsUnicode(false);

            modelBuilder.Entity<SSD>()
                .HasMany(e => e.Pc_assembly)
                .WithMany(e => e.SSD)
                .Map(m => m.ToTable("Pc_assembly_SSD").MapLeftKey("Id_SSD").MapRightKey("Id_Pc_assembly"));

            modelBuilder.Entity<users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<videocard>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
