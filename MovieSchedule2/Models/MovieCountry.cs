using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Model
{
    [Table("movie_countries")]
    public class MovieCountry
    {
        [Key]
        [Column("movie_id")]
        public int movieID { get; set; }

        [Key]
        [Column("country_id")]
        public int countryID { get; set; }

        public Movie Movie { get; set; }
        public Country Country { get; set; }
    }
}
