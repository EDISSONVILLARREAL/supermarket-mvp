using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = "";
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(
                model, validationContext, validationResults, true);

            if (!isValid)
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
