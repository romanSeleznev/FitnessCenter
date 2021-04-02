using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class Center
    {
        public int CenterId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Trener> Treners { get; set; }
        public virtual ICollection<Aboniment> Aboniments { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
      /*  public Center()
        {
            Treners = new List<Trener>();
            Aboniments = new List<Aboniment>();
            Rooms = new List<Room>();
            Clients = new List<Client>();
        }*/
    }
}
