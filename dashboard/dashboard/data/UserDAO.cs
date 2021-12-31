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

        public bool verficaUsuarioExistente(string user, string pass)
        {
     
            try
            {
                var verificaUsuario = new UserRegistrationDTO();

                using (var connection = GetConnection())
                {

                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = $@"select * from usuario where UserName=@user and Password=@pass";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        NpgsqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                         {

                              verificaUsuario.username = reader.GetString(1);
                              verificaUsuario.password = reader.GetString(2);

                         }
                        if (user != verificaUsuario.username)
                        {
                            
                            return true;
                         }
                        
                    
                        return false;
                    }
                }
             
            }
            catch (Exception)
            {
                return false;
            }
        
        }
 
        public bool cadastro(string user, string pass)
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
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
      
        }
        public bool login(string user, string pass)
        {
            var log = new UserLoginDTO(user, pass);
            try
            {

                using (var connection = GetConnection())
                {

                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = $@"select * from usuario where UserName=@user and Password=@pass"; 
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        NpgsqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                              
                                log.username = reader.GetString(1);
                                log.password = reader.GetString(2);

                            }
                            if (log.username == user && log.password == pass)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
     
    }
}
