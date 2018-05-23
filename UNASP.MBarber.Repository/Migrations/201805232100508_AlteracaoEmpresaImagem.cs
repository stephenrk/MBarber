namespace UNASP.MBarber.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoEmpresaImagem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Imagens", "Empresa_Id", "dbo.Empresas");
            DropIndex("dbo.Imagens", new[] { "Empresa_Id" });
            AddColumn("dbo.Empresas", "Imagem_Id", c => c.Guid());
            CreateIndex("dbo.Empresas", "Imagem_Id");
            AddForeignKey("dbo.Empresas", "Imagem_Id", "dbo.Imagens", "Id");
            DropColumn("dbo.Imagens", "Empresa_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imagens", "Empresa_Id", c => c.Guid());
            DropForeignKey("dbo.Empresas", "Imagem_Id", "dbo.Imagens");
            DropIndex("dbo.Empresas", new[] { "Imagem_Id" });
            DropColumn("dbo.Empresas", "Imagem_Id");
            CreateIndex("dbo.Imagens", "Empresa_Id");
            AddForeignKey("dbo.Imagens", "Empresa_Id", "dbo.Empresas", "Id");
        }
    }
}
