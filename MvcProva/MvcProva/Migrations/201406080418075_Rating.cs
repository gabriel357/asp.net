namespace MvcProva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "Classificacao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Filmes", "Classificacao");
        }
    }
}
