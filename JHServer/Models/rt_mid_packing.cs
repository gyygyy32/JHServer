namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("js_mes.rt_mid_packing")]
    public partial class rt_mid_packing
    {
        [StringLength(40)]
        public string Container_No { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string Carton_No { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string WorkOrder_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string Module_ID { get; set; }

        [StringLength(20)]
        public string Product_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Product_Type { get; set; }

        public double PMAX { get; set; }

        public double FF { get; set; }

        public double VOC { get; set; }

        public double ISC { get; set; }

        public double? RS { get; set; }

        public double? RSH { get; set; }

        public double? STANDARD_PWR { get; set; }

        public double? AVERAGE_PWR { get; set; }

        [Required]
        [StringLength(40)]
        public string State { get; set; }

        public int? RowNo { get; set; }

        public DateTime Packing_Date { get; set; }

        public DateTime? UNPacking_Date { get; set; }

        [StringLength(20)]
        public string OP_ID { get; set; }

        [StringLength(20)]
        public string UOP_ID { get; set; }

        [StringLength(20)]
        public string WorkOrder_vertion { get; set; }

        [StringLength(20)]
        public string Module_Grade { get; set; }

        [StringLength(20)]
        public string IMP_Grade { get; set; }

        public double? VPM { get; set; }

        public double? IPM { get; set; }

        public DateTime? test_date { get; set; }

        [StringLength(20)]
        public string banci { get; set; }

        [StringLength(20)]
        public string packState { get; set; }

        [StringLength(20)]
        public string workshop { get; set; }

        [StringLength(45)]
        public string Computer { get; set; }

        [StringLength(45)]
        public string Color { get; set; }
    }
}
