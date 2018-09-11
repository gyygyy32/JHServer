namespace JHServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jh_mes.tparaconfig")]
    public partial class tparaconfig
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string paratype { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string paraid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string paraname { get; set; }

        public DateTime createtime { get; set; }

        [Required]
        [StringLength(50)]
        public string createuser { get; set; }
    }
}
