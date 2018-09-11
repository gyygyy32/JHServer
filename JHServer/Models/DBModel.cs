namespace JHServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel: DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<tiqclog> tiqclogs { get; set; }
        public virtual DbSet<tpackinginfo> tpackinginfoes { get; set; }
        public virtual DbSet<tiqcdetaillog> tiqcdetaillogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tiqclog>()
                .Property(e => e.incomingno)
                .IsUnicode(false);

            modelBuilder.Entity<tiqclog>()
                .Property(e => e.supplycompany)
                .IsUnicode(false);

            modelBuilder.Entity<tiqclog>()
                .Property(e => e.materialtype)
                .IsUnicode(false);

            modelBuilder.Entity<tiqclog>()
                .Property(e => e.pinmin)
                .IsUnicode(false);

            modelBuilder.Entity<tiqclog>()
                .Property(e => e.createuser)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.lotid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.sublotid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.PinHao)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.BeforePackageWeight)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.AfterPackageWeight)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.UVCompletelotid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.PasteFilmlotid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.Subsectionlotid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.WorkOrder)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.ReWorkOrder)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.FactoryID)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.WorkshopID)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.worksitename)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.createuser)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.flowid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.lottype)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.MouldLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.FilmLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.rework)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.processcomplete)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.MouldLength)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.MouldWidth)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.RestLength)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.eqpid)
                .IsUnicode(false);

            modelBuilder.Entity<tpackinginfo>()
                .Property(e => e.RestWidth)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetaillog>()
                .Property(e => e.lot)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetaillog>()
                .Property(e => e.paratype)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetaillog>()
                .Property(e => e.parasubtype)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetaillog>()
                .Property(e => e.paraid)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetaillog>()
                .Property(e => e.result)
                .IsUnicode(false);
        }
    }
}
