using LesPetitsPas_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Interfaces
{
    internal interface IBusRepository
    {
        public IEnumerable<Bus> Get();
        public Bus Get(int id);
        public Bus Create();
        public Bus Delete(int id);
    }
}
