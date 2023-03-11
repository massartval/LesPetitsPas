using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Models
{
    internal class Parent: Person
    {
        public int ID { get; set; }
        // [PasswordPropertyText]
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
