using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data.Entities
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Required]
        public string ActorName { get; set; }

        public string? Bio { get; set; }

        public DateTime DateOfBirth {get; set; }

        public string Sex {get; set; }

        [JsonIgnore]
        public virtual ICollection<Movie> Movies {get; set; }

    }
}
