namespace MvcProva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        DataDeLançamento = c.DateTime(nullable: false),
                        Genero = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Filmes");
        }
    }
}
