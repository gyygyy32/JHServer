namespace JHServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel1 : DbContext
    {
        public DBModel1()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<tparaconfig> tparaconfigs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tparaconfig>()
                .Property(e => e.paratype)
                .IsUnicode(false);

            modelBuilder.Entity<tparaconfig>()
                .Property(e => e.paraid)
                .IsUnicode(false);

            modelBuilder.Entity<tparaconfig>()
                .Property(e => e.paraname)
                .IsUnicode(false);

            modelBuilder.Entity<tparaconfig>()
                .Property(e => e.createuser)
                .IsUnicode(false);
        }
    }
}
