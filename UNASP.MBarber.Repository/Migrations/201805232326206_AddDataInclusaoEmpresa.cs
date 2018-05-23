namespace UNASP.MBarber.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataInclusaoEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "DataInclusao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresas", "DataInclusao");
        }
    }
}
