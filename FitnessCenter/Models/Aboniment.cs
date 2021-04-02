using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class Aboniment
    {
        public int AbonimentId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Info { get; set; }
        public int? CenterId { get; set; }
        public Center Center { get; set; }

        /*public Aboniment()
        {
            Centers = new List<Center>();
        }*/
    }
}
