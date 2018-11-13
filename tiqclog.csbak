namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jh_mes.tiqclog")]
    public partial class tiqclog
    {
        public long id { get; set; }

        [Required]
        [StringLength(40)]
        public string incomingno { get; set; }

        public DateTime inspectiontime { get; set; }

        [StringLength(40)]
        public string supplycompany { get; set; }

        [StringLength(40)]
        public string materialtype { get; set; }

        [StringLength(40)]
        public string pinmin { get; set; }

        public int? thinkness { get; set; }

        public int? width { get; set; }

        public int? length { get; set; }

        public int? incomingqty { get; set; }

        //add by xue lei on 2018-10-15
        public sbyte? result { get; set; }

        

        [StringLength(20)]
        public string createuser { get; set; }
    }
}
