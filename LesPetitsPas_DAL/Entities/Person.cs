using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Models
{
    internal class Person
    {
        public int Id { get; }
        public int AdressID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Phone1 { get; set; }
        public string Phone2 { get; set; }
    }
}
