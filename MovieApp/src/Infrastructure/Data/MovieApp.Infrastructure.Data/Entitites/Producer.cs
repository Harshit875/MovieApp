using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data.Entities
{
    public class Producer
    {
        [Key]
        public int ProducerId {get; set;}

        [Required]
        public string ProducerName {get; set;}

        public string? Bio { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Sex { get; set; }

        public string? Company { get; set; }
        [JsonIgnore]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
