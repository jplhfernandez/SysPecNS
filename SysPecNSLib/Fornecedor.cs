using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {


        public int Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public string? CNPJ { get; set;}
        public string? Contato { get; set;}
        public string? Telefone { get;}
        public string? Email { get; set;}

        public Fornecedor()
        {
        
        }

        public Fornecedor(int id, string? razaoSocial, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(string? razaoSocial, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
    }     
}
