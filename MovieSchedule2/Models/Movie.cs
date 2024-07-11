using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Model
{
    public class Movie
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateOnly releaseDate { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
        public ICollection<MovieCountry> MovieCountries { get; set; }
        public ICollection<MovieDirector> MovieDirectors { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
