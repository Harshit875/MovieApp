using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data.Entities
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Plot { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public Producer Producer { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        
        public int ProducerId { get; set; } 
        public byte[]? Poster { get; set; }

    }
}
