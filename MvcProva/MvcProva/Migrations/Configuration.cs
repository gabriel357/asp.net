namespace MvcProva.Migrations
{
    using MvcProva.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcProva.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcProva.Models.MovieDBContext";
        }

        protected override void Seed(MvcProva.Models.MovieDBContext context)
        {
            context.Filmes.AddOrUpdate(i => i.Titulo,
                new Filme
                {
                    Titulo = "Os Vingadores",
                    DataDeLançamento = DateTime.Parse("12-04-2012"),
                    Genero = "Ação",
                    Classificacao = "10",
                    Preco = 25
                },

                 new Filme
                 {
                     Titulo = "Velozes e Furiosos 3: Desafio em Tokyo",
                     DataDeLançamento = DateTime.Parse("27-06-2006"),
                     Genero = "Corrida",
                     Classificacao = "13",
                     Preco= 19
                 },

                 new Filme
                 {
                     Titulo = "Círculo de Fogo",
                     DataDeLançamento = DateTime.Parse("04-11-2013"),
                     Genero = "Aventura",
                     Classificacao = "16",
                     Preco = 35
                 }

              
           );

        }
    }
}
