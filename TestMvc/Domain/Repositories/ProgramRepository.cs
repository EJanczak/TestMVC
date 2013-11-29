using System.Linq;
using TestMvc.Domain.Models;
using TestMvc.Models;

namespace TestMvc.Domain.Repositories
{
    public class ProgramRepository
    {
        public Program GetById(int id)
        {
            var context = new UsersContext();
            return context.Programs.FirstOrDefault(x => x.Id == id);
        }

    }
}