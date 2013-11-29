using System.Linq;
using System.Web.Mvc;
using TestMvc.Domain.Repositories;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class ProgramController : Controller
    {
        public ActionResult Index()
        {
            var repository = new Repository();
            var viewModel = repository.GetById(0);

            return View(viewModel);
        }
    }
}