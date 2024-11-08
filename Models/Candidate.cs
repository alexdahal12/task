using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobCandidatesApi.Models
{
    public class Candidate
    {
        public int Id { get; set; } // This is the primary key
        [Required]
        public string firstname { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        public string LinkedIn{ get; set; }

        public int Timeinterval { get; set; }
        public string GitHub { get; set; }

        [Required]
        public string TextComment { get; set; }

    }
}
