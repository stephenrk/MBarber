namespace UNASP.MBarber.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagemEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imagens", "Empresa_Id", c => c.Guid());
            CreateIndex("dbo.Imagens", "Empresa_Id");
            AddForeignKey("dbo.Imagens", "Empresa_Id", "dbo.Empresas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imagens", "Empresa_Id", "dbo.Empresas");
            DropIndex("dbo.Imagens", new[] { "Empresa_Id" });
            DropColumn("dbo.Imagens", "Empresa_Id");
        }
    }
}
