using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class ActorDto
    {
        public string ActorName { get; set; }

        public string? Bio { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Sex { get; set; }
    }
}
