using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public class Conexao
    {
        private static string connString =
            "server=10.37.44.29;user id=root;password=root;database=corpo_ativo";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}
