using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace fuzzy_llama.Core.Models
{
    [Table("Account")]
    public class User : Entity
    {
        [Required(ErrorMessage = "The name is mandatory")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Must have a minimum length of 3.")]       
        [Display(Name = "User name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The email address is mandatory")]
        [Email(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }
    }
}
