namespace JHServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class jsModel : DbContext
    {
        public jsModel()
            : base("name=jsmesConn")
        {
        }

        public virtual DbSet<rt_mid_packing> rt_mid_packing { get; set; }
        public virtual DbSet<rt_pallet_info> rt_pallet_info { get; set; }
        public virtual DbSet<rt_mid_flash_label> rt_mid_flash_label { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Container_No)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Carton_No)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.WorkOrder_ID)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Module_ID)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Product_ID)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Product_Type)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.OP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.UOP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.WorkOrder_vertion)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Module_Grade)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.IMP_Grade)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.banci)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.packState)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.workshop)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Computer)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_packing>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.pallet_no)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.final_grade)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.power_grade)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.imp_grade)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.cell_type)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.jbox_spec)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.frame_spec)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.bus_bar_type)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.unpack_op)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.product_no1)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.product_no2)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.packState)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.lowPower)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.upPower)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.workshop)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.power_grade_type)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.PackPatten)
                .IsUnicode(false);

            modelBuilder.Entity<rt_pallet_info>()
                .Property(e => e.CustomLot)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Pmax)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.IGrade)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.IType)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Vmp)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Imp)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Voc)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Isc)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Volmax)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Fusemax)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.Moduleapp)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.ProductFamily)
                .IsUnicode(false);

            modelBuilder.Entity<rt_mid_flash_label>()
                .Property(e => e.createuser)
                .IsUnicode(false);
        }
    }
}
