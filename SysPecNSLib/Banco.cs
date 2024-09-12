using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public static class Banco// classe de conexão de banco de dados
    {
        /// <summary>
        /// Método abrir da classe Banco é utilizado para representar comandos SQL 
        /// no servidor cujos os dados foram informados na string de conexão (strconn)
        /// </summary>
        /// <returns>Entrega um objeto de comandos SQL, que serão executados na conexão informada</returns>
        public static MySqlCommand Abrir() // método de conexão
        {
            // daos de conexão
            string strconn = @"server=10.91.45.21;database=syspecdb;user=root;password=root";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new();
            try// tratamento de excessão
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {
                throw;
            }
            return cmd;
        }
    }
}
