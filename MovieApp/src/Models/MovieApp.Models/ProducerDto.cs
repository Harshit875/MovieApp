using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class ProducerDto
    {
        public string ProducerName { get; set; }
        
        public string? Bio { get; set; }

        public string Company { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Sex { get; set; }

    }
}
