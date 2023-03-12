using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Models
{
    public class Child
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int ParentId { get; set; }
        // voir si bon type pour BirthDate
        public DateTime BirthDate { get; set; }
    }
}
