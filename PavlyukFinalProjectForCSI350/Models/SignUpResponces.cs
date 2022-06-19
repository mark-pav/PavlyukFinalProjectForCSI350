using System.ComponentModel.DataAnnotations;

namespace PavlyukFinalProjectForCSI350.Models
{
    public class SignUpResponces
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First Name should be no more than 20 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Last Name should be no more than 20 characters.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Range(18, 100, ErrorMessage = "We accept clients only 18+ and no older than 100")]
        public int Age { get; set; }
        [Required]
        [StringLength(600, ErrorMessage ="Please keep your description under 600 characters!")]
        public string message { get; set; }

        public SignUpResponces()
        {

        }


    }
}
