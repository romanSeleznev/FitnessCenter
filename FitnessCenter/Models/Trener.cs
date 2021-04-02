using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class Trener
    {
        public int TrenerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        
        public int? CenterId { get; set; }
        public Center Center { get; set; }
        public  Category Category { get; set; }
    }
}
