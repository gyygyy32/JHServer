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
        
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        
        [Column(Order = 1)]
        [StringLength(40)]
        public string lot { get; set; }

        [StringLength(40)]       
        public string sublot { get; set; }

        public int no { get; set; }

        [StringLength(40)]
        public string paraid { get; set; }

        [StringLength(40)]
        public string result { get; set; }
    }
}
