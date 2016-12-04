using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeafoodCod.Models
{
    [Table("newsletters")]
    public class Newsletter
    {
        [Key]
        public int NewsletterId { get; set; }
        public string Email { get; set; }
        public string Country { get; set}
    }
}
