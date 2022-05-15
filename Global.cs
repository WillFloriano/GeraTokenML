using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraToken
{
    class Global
    {
        public static string version = "1.0";
        public static Boolean loged = false;
        public static int nivel = 0;
        public static string username = "";
        public static int ID = 0;
        public static int acesso = 0;
        //public static string path = System.Environment.CurrentDirectory;
        public static string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string dataname = "gera_token.db";
        public static string pathdatabase = path + @"\banco\" + dataname;
    }
}
