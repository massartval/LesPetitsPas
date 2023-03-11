using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Entities
{
    internal class Staff
    {
        public int BusID { get; set; }
        public int GuideID { get; set; }
        public bool IsDriver { get; set; }
    }
}
