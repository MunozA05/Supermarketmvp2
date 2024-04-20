using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class ProviderModel
    {
        [DisplayName("Provider Id")]
        public int ProviderId { get; set; }

        [DisplayName("Provider Name")]
        [Required(ErrorMessage = "Provider name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Provider name must be between 3 and 100 characters")]
        public string ProviderName { get; set; }

        [DisplayName("Contact Name")]
        [Required(ErrorMessage = "Contact name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Contact name must be between 3 and 100 characters")]
        public string ProviderContactName { get; set; }

        [DisplayName("Contact Phone")]
        [Required(ErrorMessage = "Contact phone is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Contact phone must be between 3 and 20 characters")]
        public string ProviderContactPhone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Email must be between 3 and 100 characters")]
        public string ProviderEmail { get; set; }
    }
}
