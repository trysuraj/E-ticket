using eCommerce.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Nmae { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }  
        public DateAndTime StartDate { get; set; }
        public DateAndTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
