namespace UNASP.MBarber.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoEmpresaImagem1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Imagens", "Extension");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imagens", "Extension", c => c.String(nullable: false, maxLength: 4));
        }
    }
}
