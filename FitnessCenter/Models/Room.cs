using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int? CenterId { get; set; }
        public Center Center { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }

       /* public Room()
        {
            Equipments = new List<Equipment>();
        }*/
    }
}
