using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Items { get; set; }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> items)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Items = items;
        }

        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }

        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {

            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
        }

        public Pedido() 
        {
        
        }
        
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spcliente_id",Cliente.Id);
            cmd.Parameters.AddWithValue("spusuario_id",Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            ObterLista(0, 8);
            return pedido;
        }

        public static List<Pedido> ObterLista(int idCliente=0, int idUsuario=0)
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
    }
}
