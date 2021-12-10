using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DashboardBibliotecas.data
{
    public class FicharioDb
    {
        public string mensagem;
        public bool status;
        public string tabela;
        //public connection db { get; set; }
        public connection db;

        public FicharioDb()
        {
            status = true;
            try
            {
                
                db = new connection();
               // db.conexao();
                
                mensagem = "Conexão foi feita com sucesso";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Conexao com erro: {ex.Message}";
            }
        }
        public void add(int id, string username, string password,  System.Drawing.Image photo)
        {
            status = true;
            try
            {
                var SQL = $"INSERT INTO User (id, username, password, photo) VALUES('{id}, {username}, {password}, {photo}')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = $"Inclusão efetuada com sucesso. Identificador: {id}";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Inclusão com o fichario com erro: {ex.Message}";

            }

        }


    }
}
