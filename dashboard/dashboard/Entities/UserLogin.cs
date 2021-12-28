using dashboard.data;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.utils
{
    public class UserLogin : conexao
    {
        public string password { get; set; }
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

            }
        }
    }
  
