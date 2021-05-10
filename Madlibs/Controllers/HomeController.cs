using Microsoft.AspNetCore.Mvc;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    public string Hello() { return "Hello friend!"; }

    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult MadlibForm()
    {
      return View();
    }

  }
}