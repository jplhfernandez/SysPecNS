using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SysPecNSLib
{
    public class Nivel
    {
        //atributos (campo)
        //private int id;
        //private string nome;
        //private string sigla;
        //public string sigla { get { return nome; } set { nome = value; } };

        //métodos de acesso (get e set)
            //public int Id { get => id; set => id = value; }
        
        //propriedades
        public int Id {  get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        //métodos construtores
        public Nivel() { } 

        public Nivel(string nome, string sigla) //Sobrecarga de métodos
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        //métodos (requisitos)
        /// <summary>
        /// Método para inserir registro de nivel na base de dados
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis (id, nome, sigla) values (0, '{Nome}' , '{Sigla}' )";
            cmd.ExecuteNonQuery();
        }
        public static Nivel ObterPorIdI(int id)
        {
            Nivel nivel = new();
            //consulta no banco e retornar
            var cmd = Banco.Abrir() ;
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = $"SELECT * FROM niveis where id = {id};";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            //consulta para retornar a lista de niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                   new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2))
                   );
            }
            return lista;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update niveis set nome = '{Nome}', sigla = '{Sigla}' where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
            //{
            //    return true;
            //}
            //else 
            //{ 
            //    return false; 
            //}
        }
        public void Excluir(int id)
        {

        }
    }
}
