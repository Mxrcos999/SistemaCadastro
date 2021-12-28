using dashboard.utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.data
{
    public class UserDAO : conexao
    {
        public bool status { get; set; }

        public UserDAO(string user, string pass)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $@"insert into usuario (username, password) values ('{user}', '{pass}')";
                        command.CommandType = CommandType.Text;
                        NpgsqlDataReader reader = command.ExecuteReader();
                        status = true;

                    }
                }
            }
            catch (Exception)
            {
                status = false;

            }
        
        }
     
    }
}
