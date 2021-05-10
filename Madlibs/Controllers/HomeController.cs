using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    public string Hello() { return "Hello friend!"; }

    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult MadlibForm() { return View(); }

    [Route("/display")]
    public ActionResult MadlibDisplay(string noun, string pluralNoun, string presentTenseVerb, string anotherPresentTenseVerb, string partOfBodyPlural, string adjective, string anotherPluralNoun, string anotherAdjective)
    {
      MadlibVariable madlibOutput = new MadlibVariable();
      madlibOutput.Noun = noun;
      madlibOutput.PluralNoun = pluralNoun;
      madlibOutput.PresentTenseVerb = presentTenseVerb;
      madlibOutput.AnotherPresentTenseVerb = anotherPresentTenseVerb;
      madlibOutput.PartOfBodyPlural = partOfBodyPlural;
      madlibOutput.Adjective = adjective;
      madlibOutput.AnotherPluralNoun = anotherPluralNoun;
      madlibOutput.AnotherAdjective = anotherAdjective;
      return View(madlibOutput);
    }

  }
}