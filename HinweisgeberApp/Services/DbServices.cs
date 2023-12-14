using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweisgeberApp.Services
{
    public static class DbServices
    {
        public static string GetConnectionString(string Server, string UserName, string Password, string DataBase)
        {
            return $"server={Server};database = {DataBase};user id = {UserName}; password = {Password};";
        }
    }
}
