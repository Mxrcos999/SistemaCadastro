using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.utils
{
   public class UserLogin
    {
        public string password { get; set; }
        public string username { get;  set; }
    
   
        public static UserLogin DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<UserLogin>(vJson);
        }

        public bool validaSenha(string senhaComparada, string nomeComparado)
        {
            if (senhaComparada != password || nomeComparado != username)
            {
                return false;
            }
            else
            {

                return true;

            }
        }
    }
}
