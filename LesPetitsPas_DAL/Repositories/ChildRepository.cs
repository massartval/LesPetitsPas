using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;
using Tools.Ado;

namespace LesPetitsPas_DAL.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private Connection _connection;

        public ChildRepository(Connection connection)
        {
            _connection = connection;
        }
        public Child Get(int id)
        {
            string sql = "SELECT * FROM [Child] WHERE [Id] = @id";
            Command command = new Command(sql, false);
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, reader => new Child()
            {
                ID = id,
                LastName = (string)reader["LastName"],
                FirstName = (string)reader["FirstName"],
                BirthDate = (DateTime)reader["BirthDate"],
                ParentId = (int)reader["ParentId"]
            }).First();
            
        }

        public Child Create(Child child)
        {
            string sql = "INSERT INTO [Child]([FirstName], [LastName], [BirthDate], [ParentId]) OUTPUT [inserted].* VALUES (@FirstName, @LastName, @BirthDate, @ParentId)";
            Command command = new Command(sql, false);
            command.AddParameter("FirstName", child.FirstName);
            command.AddParameter("LastName", child.LastName);
            command.AddParameter("BirthDate", child.BirthDate);
            command.AddParameter("ParentId", child.ParentId);
            return (Child)_connection.ExecuteReader(command, reader => new Child()
            {
                ID = (int)reader["Id"],
                LastName = (string)reader["LastName"],
                FirstName = (string)reader["FirstName"],
                BirthDate = (DateTime)reader["BirthDate"],
                ParentId = (int)reader["ParentId"]
            }).Single();

        }

        public Child Delete(int id)
        {
            string sql = "DELETE FROM [Child] OUTPUT INSERTED * WHERE Id=@id";
            Command command = new Command(sql, false);
            command.AddParameter("id", id);
            return (Child)_connection.ExecuteReader(command, reader => new Child()
            {
                ID = (int)reader["Id"],
                LastName = (string)reader["LastName"],
                FirstName = (string)reader["FirstName"],
                BirthDate = (DateTime)reader["BirthDate"]
            });
        }

        public IEnumerable<Child> Get()
        {
            throw new NotImplementedException();
        }
    }
}
