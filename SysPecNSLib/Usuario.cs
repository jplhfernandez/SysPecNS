﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Usuario
    {
        ///// <summary>
        ///// ISSO
        ///// </summary>
        ///// <param name="id">RECEBA</param>
        ///// <param name="flaus">BORA BILL</param>
        //public void Inserir(int id, string flaus)
        //{
        //    var cmd = Banco.Abrir();
        //}
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set;}
        public string? Senha { get; set;}
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        public Usuario()
        {
            Nivel = new();
        }

        public Usuario(string? nome, string? email, string? senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(int id, string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }

        /// <summary>
        /// Obter por Id é um método estático que retorna
        /// um objeto usuário completo beseado no Id infroamdo
        /// </summary>
        /// <param name="id">Id do usuário buscado</param>
        /// <returns>Objeto Usuário com todos os campos</returns>
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                Nivel.ObterPorId(dr.GetInt32(4)),
                dr.GetBoolean(5)
                );
            }
            return usuario;
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            comandosSQL.CommandText = "select * from usuarios order by nome";
            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                        )
                    );
            }
            return lista;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = md5('{senha}')";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }

        public void Atualizar()
        {
            // usuario: nome, senha, nivel...
        }

        public void Arquivar()
        {

        }

        public void Restaurar()
        {

        }
    }        
}
