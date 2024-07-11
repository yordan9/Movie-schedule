using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Model
{
    [Table("movie_genres")]
    public class MovieGenre
    {
        [Key]
        [Column("movie_id")]
        public int movieID { get; set; }

        [Key]
        [Column("genre_id")]
        public int genreID { get; set; }

        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
