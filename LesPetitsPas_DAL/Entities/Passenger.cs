using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Models
{
    internal class Passenger
    {
        public int BusID { get; set; }
        public int ChildID { get; set; }
        public string DestinationID { get; set; }
        public bool IsPresent { get; set; }
        public bool IsArrived { get; set; }
    }
}
