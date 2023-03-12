using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;
using LesPetitsPas_DAL.Tools.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LesPetitsPas_DAL.Repositories
{
    internal class ChildRepository : IChildRepository
    {
        private readonly 
        public Child Create(Child child)
        {
            Command command = new Command("INSERT INTO Child (@Id) VALUES @Id),", false);
            command.AddParameter("Id", child.ID); 
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public Child Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Child> Get()
        {
            throw new NotImplementedException();
        }

        public Child Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
