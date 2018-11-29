namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jh_mes.tiqcdetaillog")]
    public partial class tiqcdetaillog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string lot { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string paratype { get; set; }

        [StringLength(40)]
        public string parasubtype { get; set; }

        [StringLength(40)]
        public string paraid { get; set; }

        [StringLength(40)]
        public string result { get; set; }

        [StringLength(40)]
        public string sublot { get; set; }
    }
}
