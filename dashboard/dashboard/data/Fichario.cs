using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.data
{
    public class Fichario
    {

        private string diretorio;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
            }
            catch (Exception )
            {
                status = false;
            }

        }

        public bool add(string user, string jsonUnit)
        {
            try
            {
                if (File.Exists($"{diretorio}\\{user}.json"))
                {
                    return false;
                }
                else
                {
                    File.WriteAllText($"{diretorio}\\{user}.json", jsonUnit);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;

            }

        }
        public string search(string user)
        {
            status = true;
            try
            {
                if (!(File.Exists(@$"{diretorio}\{user}.json")))
                {
                    status = false;
                }
                else
                {
                    string conteudo = File.ReadAllText(@$"{diretorio}\{user}.json");
                    status = true;
                    return conteudo;
                }
            }
            catch (Exception)
            {
                status = false;            }
            return "";
        }

    }
}
