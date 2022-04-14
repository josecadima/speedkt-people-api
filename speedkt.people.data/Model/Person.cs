using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedkt.people.data.Model
{
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string NickName { get; set; }

        public Guid AvatarID { get; set; }
    }
}
