using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;
using Tools.Ado;

namespace LesPetitsPas_DAL.Repositories
{
    internal class PersonRepository : IPersonRepository
    {
        private Connection _connection;

        public PersonRepository(Connection connection)
        {
            _connection = connection;
        }

        public Person Get(int id)
        {
            string sql = "SELECT * FROM [Person] WHERE [Id] = @id";
            Command command = new Command(sql, false);
            command.AddParameter("id", id);
            return (Person)_connection.ExecuteReader(command, reader => new Person()
            {
                Id = (int)reader["Id"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Email = (string)reader["Email"],
                AddressID = (int)reader["AddressId"],
                Phone1 = (string)reader["Phone1"],
                Phone2 = (string)reader["Phone2"],
            });
        }

        public Person Create(Person person)
        {
            string sql = "INSERT INTO [Person]([FirstName], [LastName], [Email], [AddressId], [Phone1], [Phone2]) OUTPUT [inserted].* VALUES(@firstName, @lastName, @email, @addressId, @phone1, @phone2)";
            Command command = new Command(sql, false);
            command.AddParameter("firstName", person.FirstName);
            command.AddParameter("lastName", person.LastName);
            command.AddParameter("email", person.Email);
            command.AddParameter("addressId", person.AddressID);
            command.AddParameter("phone1", person.Phone1);
            command.AddParameter("phone2", person.Phone2);
            return (Person)_connection.ExecuteReader(command, reader => new Person()
            {
                Id = (int)reader["Id"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Email = (string)reader["Email"],
                AddressID = (int)reader["AddressId"],
                Phone1 = (string)reader["Phone1"],
                Phone2 = (string)reader["Phone2"],
            });
        }
        public int MakeTrusted(int ParentId, int PersonId)
        {
            string sql = "INSERT INTO [Trusted]([ParentId], [PersonId]) OUTPUT [inserted].* VALUES(@parentId, personId)";
            Command command = new Command(sql, false);
            return _connection.ExecuteNonQuery(command);
        }
    }
}
