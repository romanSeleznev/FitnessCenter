using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class Category
    {
        [Key]
        [ForeignKey("Trener")]
        public int TrenerId { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public Trener Trener { get; set; }
    }
}
