using Ejercicio1._3.Models;
using SQLite;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio1._3.Controllers
{
    public class FuntionsApiController
    {
        readonly SQLiteAsyncConnection _connection;
        public FuntionsApiController() { }
        public FuntionsApiController(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Personas>().Wait();

        }

        public Task<int> AddPeople(Personas personas)
        {
            if (personas.id == 0)
            {
                return _connection.InsertAsync(personas);
            }
            else
            {
                return _connection.UpdateAsync(personas);
            }
        }

        public Task<List<Personas>> GetListPople()
        {
            return _connection.Table<Personas>().ToListAsync();
        }

        public Task<Personas> GetPersonForId(int id)
        {
            return _connection.Table<Personas>().Where(p => p.id == id).FirstOrDefaultAsync();
        }

        public Task<int> delete(Personas personas)
        {
            return _connection.DeleteAsync(personas);
        }

    }
}
