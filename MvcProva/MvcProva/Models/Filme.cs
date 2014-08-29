using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcProva.Models
{
    public class Filme
    {

       
        public int ID { get; set; }

         [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]

        public DateTime DataDeLançamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Classificacao { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
    }
}