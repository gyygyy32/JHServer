namespace JHServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<tiqcdetailresultlog> tiqcdetailresultlogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tiqcdetailresultlog>()
                .Property(e => e.lot)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetailresultlog>()
                .Property(e => e.paraid)
                .IsUnicode(false);

            modelBuilder.Entity<tiqcdetailresultlog>()
                .Property(e => e.result)
                .IsUnicode(false);
        }
    }
}
