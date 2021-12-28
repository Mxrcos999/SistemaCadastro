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
    public class UserLogin : conexao
    {

        [Required(ErrorMessage = "The password field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter a valid password!")]
        public string password { get; set; }
       
        [Required(ErrorMessage = "The username field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter a valid user!")]
        public string username { get; set; }

        public bool status { get; set; }


        public void login(string user, string pass)
        {
            var sqlQuery = $@"select * from usuario where UserName=@user and Password=@pass";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sqlQuery;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            username = reader.GetString(1);
                            password = reader.GetString(2);

                        }
                        if (username == user && password == pass)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                 
            
                  }
                }
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
  
