namespace UNASP.MBarber.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    using UNASP.MBarber.Repository.ConnectionContext;
    using UNASP.MBarber.Repository.ConnectionContext.Context;

    internal sealed class Configuration : DbMigrationsConfiguration<MBarberContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MBarberContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.TipoServico.AddOrUpdate(
                ts => ts.Descricao,
                new TipoServico { Descricao = "Corte" },
                new TipoServico { Descricao = "Barba" }
                );
        }
    }
}
