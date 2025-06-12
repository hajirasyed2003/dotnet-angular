using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDb.DAL.Models
{
    public class UserInfo
    {
        [Key]
        [Column("EmailId")]
        
        public string EmailID { get; set; }

        [Column("UserName")]
        [Required]
        [StringLength(maximumLength:50, MinimumLength =1)]
        public string UserName { get; set; }

        [Column("Role")]
        [Required]
        [RegularExpression("Admin|Participant")]
        public string Role { get; set; }

        [Column("Password")]
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 6)]
        public string Password { get; set; }

    }
}
