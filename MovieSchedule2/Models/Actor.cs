using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieSchedule2.Model
{
    public class Actor
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
