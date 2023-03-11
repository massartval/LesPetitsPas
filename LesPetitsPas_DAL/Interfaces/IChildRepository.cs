using LesPetitsPas_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Interfaces
{
    internal interface IChild
    {
        public IEnumerable<Child> Get();
        public Child Get(int id);
        public Child Create();
        public Child Delete(int id);
    }
}
