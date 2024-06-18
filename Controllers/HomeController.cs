using Microsoft.AspNet.Mv3;

using MyNamespace.Controllers;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
	{
        public ICtionResult Index()
        {
            return Content("Hello World!");
        }
    }
}
