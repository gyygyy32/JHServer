namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jh_mes.tpackinginfo")]
    public partial class tpackinginfo
    {
        [Key]
        [StringLength(40)]
        public string lotid { get; set; }

        [StringLength(40)]
        public string sublotid { get; set; }

        [StringLength(40)]
        public string PinHao { get; set; }

        [StringLength(40)]
        public string ProductType { get; set; }

        [StringLength(20)]
        public string BeforePackageWeight { get; set; }

        [StringLength(20)]
        public string AfterPackageWeight { get; set; }

        [StringLength(40)]
        public string UVCompletelotid { get; set; }

        [StringLength(40)]
        public string PasteFilmlotid { get; set; }

        [StringLength(40)]
        public string Subsectionlotid { get; set; }

        [StringLength(40)]
        public string WorkOrder { get; set; }

        [StringLength(45)]
        public string ReWorkOrder { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(20)]
        public string FactoryID { get; set; }

        [StringLength(20)]
        public string WorkshopID { get; set; }

        public sbyte? flowidno { get; set; }

        [StringLength(20)]
        public string worksitename { get; set; }

        public DateTime? checkintime { get; set; }

        public DateTime? checkouttime { get; set; }

        public DateTime createtime { get; set; }

        [StringLength(20)]
        public string createuser { get; set; }

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
    }
}
