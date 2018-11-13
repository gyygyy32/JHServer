namespace JHServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<tiqclog> tiqclog { get; set; }

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
        }
    }
}
