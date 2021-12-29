using dashboard.data;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.utils
{
    public class UserLoginDTO : conexao
    {

        [Required(ErrorMessage = "The password field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter a valid password!")]
        public string password { get; set; }
       
        [Required(ErrorMessage = "The username field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter a valid user!")]
        public string username { get; set; }

        
        public UserLoginDTO(string user, string pass)
        {
            username = user;
            password = pass;
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }

    }
}
  
