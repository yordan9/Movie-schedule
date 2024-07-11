using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Model
{
    public class Country
    {
        [Key]
        [Column ("id")]
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<MovieCountry> MovieCountries { get; set; }
    }
}
