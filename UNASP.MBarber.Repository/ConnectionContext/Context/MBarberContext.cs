using System.Data.Entity;

namespace UNASP.MBarber.Repository.ConnectionContext.Context
{
    public partial class MBarberContext : DbContext
    {
        public MBarberContext() : base("name=MBarberContext")
        {
        }

        public virtual DbSet<Agendamento> Agendamentos { get; set; }
        public virtual DbSet<Avaliacao> Avaliacoes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendamento>()
                .HasMany(e => e.Servicos)
                .WithRequired(e => e.Agendamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Sobrenome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Agendamentos)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.NomeReduzido)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Servicos)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Cep)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Servico>()
                .Property(e => e.Valor)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Servico>()
                .HasMany(e => e.Avaliacoes)
                .WithRequired(e => e.Servico)
                .WillCascadeOnDelete(false);
        }
    }
}
