using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Model
{
    [Table("movie_directors")]
    public class MovieDirector
    {
        [Key]
        [Column("movie_id")]
        public int movieID { get; set; }

        [Key]
        [Column("director_id")]
        public int directorID { get; set; }

        public Movie Movie { get; set; }
        public Director Director { get; set; }
    }
}
