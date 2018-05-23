namespace UNASP.MBarber.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadeImagem1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Image", newName: "Imagens");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Imagens", newName: "Image");
        }
    }
}
