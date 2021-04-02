using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }
        
    }
}
