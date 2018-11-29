namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("js_mes.rt_mid_flash_label")]
    public partial class rt_mid_flash_label
    {
        [StringLength(40)]
        public string ProductType { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string Pmax { get; set; }

        [Key]
        [Column(Order = 1)]
        public double UPPERPOWER { get; set; }

        [Key]
        [Column(Order = 2)]
        public double LOWERPOWER { get; set; }

        [StringLength(20)]
        public string IGrade { get; set; }

        [StringLength(20)]
        public string IType { get; set; }

        public double? UPPERIMP { get; set; }

        public double? LOWERIMP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Vmp { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Imp { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Voc { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string Isc { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string Volmax { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(40)]
        public string Fusemax { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(40)]
        public string Moduleapp { get; set; }

        [StringLength(40)]
        public string ProductFamily { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(45)]
        public string createuser { get; set; }

        public DateTime? createtime { get; set; }
    }
}
