using System.Linq;
using TestMvc.Domain.Models;
using TestMvc.Models;

namespace TestMvc.Domain.Repositories
{
    public class Repository<T> where T:EntityBase
    {
        public T GetById(int id)
        {
            var context = new UsersContext();
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

    }
}