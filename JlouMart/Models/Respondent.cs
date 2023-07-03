using System.ComponentModel.DataAnnotations;

namespace JlouMart.Models
{
    public class Respondent
    {
        /*[Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(@"[A-Z]+", ErrorMessage = "Only upper case characters are allowed.")]
        public string ID { get; set; }
        */
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a Valid Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Message is too short.")]
        public string Message { get; set; }

    }
}
