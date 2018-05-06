namespace UNASP.MBarber.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Primeiramigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        ClienteId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cpf = c.String(nullable: false, maxLength: 14, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 50, unicode: false),
                        EnderecoId = c.Int(nullable: false),
                        Login_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecos", t => t.EnderecoId, cascadeDelete: true)
                .ForeignKey("dbo.Logins", t => t.Login_Id)
                .Index(t => t.EnderecoId)
                .Index(t => t.Login_Id);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.String(nullable: false, maxLength: 10, unicode: false),
                        Logradouro = c.String(nullable: false, maxLength: 150, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 20, unicode: false),
                        Complemento = c.String(maxLength: 150, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataInclusao = c.DateTime(nullable: false),
                        Tipo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servicos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AgendamentoId = c.Int(nullable: false),
                        EmpresaId = c.Guid(nullable: false),
                        Valor = c.Decimal(nullable: false, storeType: "smallmoney"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId)
                .ForeignKey("dbo.Agendamentos", t => t.AgendamentoId)
                .Index(t => t.AgendamentoId)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Avaliacoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nota = c.String(nullable: false, maxLength: 5, unicode: false),
                        Descricao = c.String(unicode: false),
                        ServicoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicos", t => t.ServicoId)
                .Index(t => t.ServicoId);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cnpj = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 255, unicode: false),
                        NomeReduzido = c.String(nullable: false, maxLength: 50, unicode: false),
                        EnderecoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecos", t => t.EnderecoId, cascadeDelete: true)
                .Index(t => t.EnderecoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servicos", "AgendamentoId", "dbo.Agendamentos");
            DropForeignKey("dbo.Servicos", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.Empresas", "EnderecoId", "dbo.Enderecos");
            DropForeignKey("dbo.Avaliacoes", "ServicoId", "dbo.Servicos");
            DropForeignKey("dbo.Clientes", "Login_Id", "dbo.Logins");
            DropForeignKey("dbo.Clientes", "EnderecoId", "dbo.Enderecos");
            DropForeignKey("dbo.Agendamentos", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Empresas", new[] { "EnderecoId" });
            DropIndex("dbo.Avaliacoes", new[] { "ServicoId" });
            DropIndex("dbo.Servicos", new[] { "EmpresaId" });
            DropIndex("dbo.Servicos", new[] { "AgendamentoId" });
            DropIndex("dbo.Clientes", new[] { "Login_Id" });
            DropIndex("dbo.Clientes", new[] { "EnderecoId" });
            DropIndex("dbo.Agendamentos", new[] { "ClienteId" });
            DropTable("dbo.Empresas");
            DropTable("dbo.Avaliacoes");
            DropTable("dbo.Servicos");
            DropTable("dbo.Logins");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Agendamentos");
        }
    }
}
