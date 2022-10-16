using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieDto
    {
        public string Title { get; set; }
        public string Plot { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public int ProducerId { get; set; }

        [NotMapped]
        public ICollection<int> ActorIds { get; set; }

    }
}
