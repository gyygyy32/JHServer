namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("js_mes.rt_pallet_info")]
    public partial class rt_pallet_info
    {
        [Key]
        [StringLength(45)]
        public string pallet_no { get; set; }

        [Required]
        [StringLength(20)]
        public string state { get; set; }

        [Required]
        [StringLength(20)]
        public string final_grade { get; set; }

        [StringLength(45)]
        public string ProductType { get; set; }

        [Required]
        [StringLength(20)]
        public string power_grade { get; set; }

        public double? avg_power { get; set; }

        [Required]
        [StringLength(20)]
        public string imp_grade { get; set; }

        [StringLength(45)]
        public string Color { get; set; }

        [Required]
        [StringLength(45)]
        public string cell_type { get; set; }

        public Int16 cell_qty { get; set; }

       
        [StringLength(45)]
        public string jbox_spec { get; set; }

       
        [StringLength(45)]
        public string frame_spec { get; set; }

        [Required]
        [StringLength(20)]
        public string bus_bar_type { get; set; }

        public DateTime? unpack_date { get; set; }

        [StringLength(20)]
        public string unpack_op { get; set; }

        [StringLength(45)]
        public string product_no1 { get; set; }

        [StringLength(45)]
        public string product_no2 { get; set; }

        [StringLength(20)]
        public string packState { get; set; }

        [StringLength(20)]
        public string lowPower { get; set; }

        [StringLength(20)]
        public string upPower { get; set; }

        public DateTime? finished_time { get; set; }

        [StringLength(20)]
        public string workshop { get; set; }

        public Int16? pack_count { get; set; }

        [StringLength(10)]
        public string power_grade_type { get; set; }

        [StringLength(345)]
        public string PackPatten { get; set; }

        [StringLength(50)]
        public string CustomLot { get; set; }
    }
}
