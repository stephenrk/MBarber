using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UNASP.Projeto.DTO
{
    public class ConnectionDB : DbContext
    {
        public ConnectionDB() : base("name=connection") { }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<ClienteDTO> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}