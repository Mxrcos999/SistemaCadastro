using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace dashboard.data
{
    public abstract class conexao
    {
        public string stringcoon { get; set; }
        
        public string msg { get; set; }
        public void conectar()
        {
           
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    msg = "Sucesso";
                }
                else
                {
                    msg = "erro";
                }
            }
        }

       public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection($@"Server=127.0.0.1;
                  Username=postgres;
                  Database=cadastro;
                  Port=5432;
                  Password=26092004;
                  ");
        }




    }
}
