namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jh_mes.tlotbasis")]
    public partial class tlotbasi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string lotid { get; set; }

        [StringLength(40)]
        public string Carvelotid { get; set; }

        [StringLength(40)]
        public string Outwardlotid { get; set; }

        [StringLength(40)]
        public string UVCompletelotid { get; set; }

        [StringLength(40)]
        public string Gritlotid { get; set; }

        [StringLength(40)]
        public string PasteFilmlotid { get; set; }

        [StringLength(40)]
        public string Subsectionlotid { get; set; }

        [Required]
        [StringLength(40)]
        public string WorkOrder { get; set; }

        [StringLength(45)]
        public string ReWorkOrder { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(20)]
        public string FactoryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WorkshopID { get; set; }

        public sbyte flowidno { get; set; }

        [StringLength(20)]
        public string worksitename { get; set; }

        public DateTime? checkintime { get; set; }

        public DateTime? checkouttime { get; set; }

        public DateTime createtime { get; set; }

        [StringLength(20)]
        public string createuser { get; set; }

        [Required]
        [StringLength(20)]
        public string flowid { get; set; }

        [StringLength(20)]
        public string lottype { get; set; }

        public int? lotcount { get; set; }

        [StringLength(20)]
        public string MouldLevel { get; set; }

        [StringLength(20)]
        public string FilmLevel { get; set; }

        [StringLength(20)]
        public string rework { get; set; }

        [StringLength(20)]
        public string processcomplete { get; set; }

        [StringLength(20)]
        public string MouldLength { get; set; }

        [StringLength(20)]
        public string MouldWidth { get; set; }

        [StringLength(20)]
        public string RestLength { get; set; }

        [StringLength(40)]
        public string eqpid { get; set; }

        [StringLength(20)]
        public string RestWidth { get; set; }

        [StringLength(10)]
        public string Package { get; set; }

        public DateTime? PackageTime { get; set; }

        [StringLength(20)]
        public string PackageUser { get; set; }

        [StringLength(10)]
        public string Warehouse { get; set; }

        [StringLength(10)]
        public string Shipment { get; set; }

        [StringLength(10)]
        public string ValidWidth { get; set; }

        [StringLength(10)]
        public string ValidLength { get; set; }
    }
}
