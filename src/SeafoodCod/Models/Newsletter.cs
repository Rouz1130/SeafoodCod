using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
 // Creating this model "Newsletter" we are tying each newsletter to a user.//
// We are adding a new table "newsletters" to our DB, we need to add a newsletters Db set to our applicationDbContext.//
namespace SeafoodCod.Models
{
    [Table("newsletters")]
    public class Newsletter
    {
        [Key]
        public int NewsletterId { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public virtual ApplicationUser  User { get; set; }
    }
}
