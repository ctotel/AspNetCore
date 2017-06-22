using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeppApp.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        public string Gene { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(0,200.00)]
        public decimal Price { get; set; }

        public int Rank { get; set; }
    }
}
