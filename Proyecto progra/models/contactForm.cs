using System.ComponentModel.DataAnnotations;

namespace PortfolioRazorPages.Models
{
    public class ContactForm
    {
        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public string Message { get; set; }
    }
}
