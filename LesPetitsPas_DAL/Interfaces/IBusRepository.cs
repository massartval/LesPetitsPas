using LesPetitsPas_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Interfaces
{
    public interface IBusRepository
    {
        public IEnumerable<Bus> Get();
        public Bus Get(int id);
        public Bus Create(Bus bus);
        public Bus Delete(int id);
        
    }
}
