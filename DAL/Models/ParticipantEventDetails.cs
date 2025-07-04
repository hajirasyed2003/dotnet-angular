using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventDb.DAL.Models
{
    public class ParticipantEventDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ParticipantEmailId { get; set; }

        [Required]
        public int EventId { get; set; }

        [RegularExpression("Yes|No")]
        public string IsAttended { get; set; }
    }
}
