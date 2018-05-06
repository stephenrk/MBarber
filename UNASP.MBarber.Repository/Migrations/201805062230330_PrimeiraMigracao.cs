namespace UNASP.MBarber.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiraMigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        Cliente_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cpf = c.String(nullable: false, maxLength: 14, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 50, unicode: false),
                        Endereco_Id = c.Int(),
                        Login_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecos", t => t.Endereco_Id)
                .ForeignKey("dbo.Logins", t => t.Login_Id)
                .Index(t => t.Endereco_Id)
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
                        Valor = c.Decimal(nullable: false, storeType: "smallmoney"),
                        Empresa_Id = c.Guid(nullable: false),
                        Agendamento_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresas", t => t.Empresa_Id)
                .ForeignKey("dbo.Agendamentos", t => t.Agendamento_Id)
                .Index(t => t.Empresa_Id)
                .Index(t => t.Agendamento_Id);
            
            CreateTable(
                "dbo.Avaliacaos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nota = c.String(nullable: false, maxLength: 5, unicode: false),
                        Descricao = c.String(unicode: false),
                        Servico_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicos", t => t.Servico_Id)
                .Index(t => t.Servico_Id);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cnpj = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 255, unicode: false),
                        NomeReduzido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Endereco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecos", t => t.Endereco_Id)
                .Index(t => t.Endereco_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servicos", "Agendamento_Id", "dbo.Agendamentos");
            DropForeignKey("dbo.Servicos", "Empresa_Id", "dbo.Empresas");
            DropForeignKey("dbo.Empresas", "Endereco_Id", "dbo.Enderecos");
            DropForeignKey("dbo.Avaliacaos", "Servico_Id", "dbo.Servicos");
            DropForeignKey("dbo.Clientes", "Login_Id", "dbo.Logins");
            DropForeignKey("dbo.Clientes", "Endereco_Id", "dbo.Enderecos");
            DropForeignKey("dbo.Agendamentos", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Empresas", new[] { "Endereco_Id" });
            DropIndex("dbo.Avaliacaos", new[] { "Servico_Id" });
            DropIndex("dbo.Servicos", new[] { "Agendamento_Id" });
            DropIndex("dbo.Servicos", new[] { "Empresa_Id" });
            DropIndex("dbo.Clientes", new[] { "Login_Id" });
            DropIndex("dbo.Clientes", new[] { "Endereco_Id" });
            DropIndex("dbo.Agendamentos", new[] { "Cliente_Id" });
            DropTable("dbo.Empresas");
            DropTable("dbo.Avaliacaos");
            DropTable("dbo.Servicos");
            DropTable("dbo.Logins");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Agendamentos");
        }
    }
}
