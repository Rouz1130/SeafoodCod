using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeafoodCod.Models
{
    [Table("marketings")]
    public class Marketing
    {
        [Key]
        public int MarketingId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
       
       

    }
}
