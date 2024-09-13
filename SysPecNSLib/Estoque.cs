using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public Produto Produto_id { get; set; }
        public double Quantidade { get; set; }
        public DateTime? Data_ultimo_movimento { get; set; } = DateTime.Now;

        public Estoque(Produto produto_id, double quantidade, DateTime? data_ultimo_movimento)
        {
            Produto_id = produto_id;
            Quantidade = quantidade;
            Data_ultimo_movimento = data_ultimo_movimento;
        }

        public Estoque()
        {
        }

        public Estoque(Produto produto_id, double quantidade)
        {
            Produto_id = produto_id;
            Quantidade = quantidade;
        }

        public void InserirProduto(int produto_id, double quant)
        {
            var cmd = Banco.Abrir();
            Produto_id = produto_id.ToString();
            Quantidade = quant;
            cmd.CommandText = $"update into estoques(produto_id, quantidade) values ({produto_id}, {quant})";
        }
    }
}
