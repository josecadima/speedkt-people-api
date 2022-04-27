using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedkt.people.data.Model
{
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }

        [Required]
        public Guid PersonId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Auth0Id { get; set; } = string.Empty;
    }
}
