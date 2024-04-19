using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoryModel
    {
        [DisplayName("Category Id")]
        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 100 characters")]
        public string CategoryName { get; set; }

        [DisplayName("Category Description")]
        [Required(ErrorMessage = "Category description is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Category description must be between 3 and 100 characters")]
        public string CategoryDescription { get; set; }
    }
}
