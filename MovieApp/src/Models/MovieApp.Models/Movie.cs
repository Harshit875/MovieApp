using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Plot { get; set; }
        public DateOnly ReleaseDate {get; set; }
        public string Producer { get; set; }



    }
}
