namespace JHServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tlotbasi> tlotbasis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.lotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Carvelotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Outwardlotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.UVCompletelotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Gritlotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.PasteFilmlotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Subsectionlotid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.WorkOrder)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.ReWorkOrder)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.FactoryID)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.WorkshopID)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.worksitename)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.createuser)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.flowid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.lottype)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.MouldLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.FilmLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.rework)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.processcomplete)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.MouldLength)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.MouldWidth)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.RestLength)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.eqpid)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.RestWidth)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Package)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.PackageUser)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Warehouse)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.Shipment)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.ValidWidth)
                .IsUnicode(false);

            modelBuilder.Entity<tlotbasi>()
                .Property(e => e.ValidLength)
                .IsUnicode(false);
        }
    }
}
