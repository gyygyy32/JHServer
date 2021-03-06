namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jh_mes.tiqcdetailresultlog")]
    public partial class tiqcdetailresultlog
    {
        [Key]
        public long primaryid { get; set; }

        public long id { get; set; }

        [Required]
        [StringLength(40)]
        public string lot { get; set; }

        [StringLength(40)]
        public string sublot { get; set; }

        public int? no { get; set; }

        [StringLength(40)]
        public string paraid { get; set; }

        [StringLength(40)]
        public string result { get; set; }
    }
}
