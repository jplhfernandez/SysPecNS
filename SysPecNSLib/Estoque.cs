using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public int Produto_id { get; set; }
        public double Quantidade { get; set; }
        public DateTime? Data_ultimo_movimento { get; set; } = DateTime.Now;

        public Estoque(int produto_id, double quantidade, DateTime? data_ultimo_movimento)
        {
            Produto_id = produto_id;
            Quantidade = quantidade;
            Data_ultimo_movimento = data_ultimo_movimento;
        }

        public Estoque()
        {
        }

        public Estoque(double quantidade, DateTime? data_ultimo_movimento)
        {
            Quantidade = quantidade;
            Data_ultimo_movimento = data_ultimo_movimento;
        }

        public void InserirProduto()
        {
            var cmd = Banco.Abrir();
            //cmd.CommandType = "";
        }
    }
}
