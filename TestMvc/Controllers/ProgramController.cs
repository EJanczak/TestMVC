using System.Linq;
using System.Web.Mvc;
using TestMvc.Domain.Models;
using TestMvc.Domain.Repositories;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class ProgramController : Controller
    {
        private readonly Repository<Program> _programRepository;

        public ProgramController(Repository<Program> programRepository )
        {
            _programRepository = programRepository;
        }

        public ActionResult Index()
        {

            var viewModel = _programRepository.GetById(0);

            return View(viewModel);
        }
    }
}