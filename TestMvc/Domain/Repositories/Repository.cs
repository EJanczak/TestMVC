using System.Data.Entity;
using System.Linq;
using TestMvc.Domain.Models;
using TestMvc.Models;

namespace TestMvc.Domain.Repositories
{
    public class Repository<T> where T:EntityBase
    {
        private readonly UsersContext _dbContext;

        public Repository(UsersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

    }
}