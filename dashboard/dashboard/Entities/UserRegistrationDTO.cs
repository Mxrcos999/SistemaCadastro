using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using dashboard.data;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace dashboard.utils
{
 
    public class UserRegistrationDTO : conexao
    {
 
        [Required(ErrorMessage = "The username field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter a valid user!")]
        public string username { get;  set; }

        [Required (ErrorMessage = "The password field is required.")]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Please enter a valid password!")]

        public string password { get; set; }

        public void TrataDados(string user, string pass)
        {
            username = user.Trim();

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
    