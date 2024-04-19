using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
        [DisplayName("Pay Mode Nam")]
        [Required(ErrorMessage ="Pay mode name is required")]
        [StringLength(50, MinimumLength =3,
            ErrorMessage ="Pay mode name must be between 3 and 50 characters")]

        public string Name {  get; set; }

        public void Validate(object model) 
        {
            string errorMessage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(
                model, validationContext, validationResults, true);
            if (isValid ==false)
            {
                foreach (var item in validationResults)
                {
                    errorMessage += item.ErrorMessage + "\n";
                }
                throw new Exception(errorMessage);
            }
        }
    }
}
