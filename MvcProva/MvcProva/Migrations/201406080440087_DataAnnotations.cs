namespace MvcProva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Filmes", "Titulo", c => c.String(maxLength: 60));
            AlterColumn("dbo.Filmes", "Genero", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Filmes", "Classificacao", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filmes", "Classificacao", c => c.String());
            AlterColumn("dbo.Filmes", "Genero", c => c.String());
            AlterColumn("dbo.Filmes", "Titulo", c => c.String());
        }
    }
}
