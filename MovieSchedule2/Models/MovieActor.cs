using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Model
{
    [Table("movie_actors")]
    public class MovieActor 
    {
        [Key]
        [Column("movie_id")]
        public int movieID { get; set; }

        [Key]
        [Column("actor_id")]
        public int actorID { get; set; }

        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
