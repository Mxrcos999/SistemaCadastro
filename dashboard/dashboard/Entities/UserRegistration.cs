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
    public class UserRegistration 
    {
        
        public bool _status { get; set; }

        [Required(ErrorMessage = "The username field is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter a valid user!")]
        public string username { get;  set; }

        [Required (ErrorMessage = "The password field is required.")]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Please enter a valid password!")]

        public string password { get; private set; }

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
            var enviaDado = new UserDAO(username, password);
            _status = enviaDado.status;
        }


                /*   public void usuario()
                   {
                       //public void Incluir(string Id, string jsonUnit)
                       //{
                       //    status = true;
                       //    try
                       //    {
                       //        // INSERT INTO CLIENTE (ID, JSON) VALUES ('000001','{...}')

                       //        var SQL = "INSERT INTO " + tabela + " (Id, JSON) VALUES ('" + Id + "', '" + jsonUnit + "')";
                       //        db.SQLCommand(SQL);
                       //        status = true;
                       //        mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;

                       //    }
                       //    catch (Exception ex)
                       //    {
                       //        status = false;
                       //        mensagem = "Conexão com o Fichario com erro: " + ex.Message;
                       //    }
                       //}
                       using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringcoon))
                       {
                           //Abra a conexão com o PgSQL                  
                           pgsqlConnection.Open();

                           string cmdInserir = String.Format("Insert Into usuario(1,username,password) values('{0}',{1})", username, password);

                           using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                           {
                               pgsqlcommand.ExecuteNonQuery();
                           }
                       }
                   }
                */

            }
    }
    