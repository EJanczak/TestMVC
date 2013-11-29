using System.Linq;
using System.Web.Mvc;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class ProgramController : Controller
    {
        public ActionResult Index()
        {
            var context = new UsersContext();
            var viewModel = context.Programs.FirstOrDefault();


            return View(viewModel);
        }
    }
}