using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Models
{
    internal class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
    }
}
