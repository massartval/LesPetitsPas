using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;


namespace LesPetitsPas_DAL.Repositories
{
    public class BusRepository : IBusRepository
    {
        private Connection _connection;
        public BusRepository(Connection connection)
        {
            _connection = connection;
        }

        public Bus Create(Bus bus)
        {
            string sql = "INSERT INTO [Bus] ([DateTime]) OUTPUT [inserted].* VALUES @datetime";
            Command command = new Command(sql, false);
            command.AddParameter("DateTime", bus.DateTime);
            return (Bus)_connection.ExecuteReader(command, reader => new Bus()
            {
                DateTime = Convert.ToDateTime(reader["DateTime"])
            });
        }

        Bus IBusRepository.Delete(int id)
        {
            string sql = "DELETE FROM [Bus] OUTPUT INSERTED.* WHERE Id =@id";
            Command command = new Command(sql, false);
            command.AddParameter("Id",id);

            return (Bus)_connection.ExecuteReader(command, reader => new Bus()
            {
                DateTime = Convert.ToDateTime(reader["DateTime"])
            });

        }

        IEnumerable<Bus> IBusRepository.Get()
        {
            string sql = "SELECT * FROM [Bus]";
            Command command = new Command(sql, false);
            return _connection.ExecuteReader(command, reader => new Bus()
            {
                DateTime = Convert.ToDateTime(reader["DateTime"])
            });
        }

        Bus IBusRepository.Get(int id)
        {
            string sql = "SELECT * FROM [Bus] WHERE [Id] = @id";
            Command command = new Command(sql, false);
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, reader => new Bus()
            {
                Id = id,
                DateTime = Convert.ToDateTime(reader["DateTime"]),
            }).Single();
        }
    }
}
