using System.ComponentModel.DataAnnotations;

namespace speedkt.people.data.Model
{
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string NickName { get; set; } = string.Empty;

        public Guid? AvatarId { get; set; }
    }
}
