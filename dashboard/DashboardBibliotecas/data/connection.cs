using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DashboardBibliotecas.data
{
    public class connection
    {
        public string stringConn;
        public SqlConnection conn;

        public connection()
        {
            try
            {
                stringConn = "MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\data\\Fichario.mdf;Integrated Security=True";
                conn = new SqlConnection(stringConn);
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        





        }
        public DataTable SQLQuery(string SQL)
        {
            var dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(SQL, conn);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return dt;

        }
        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, conn);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public void Close()
        {
            conn.Close();
        }
    }
}
