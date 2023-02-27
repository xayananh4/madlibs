using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult index() { return View(); }
    
    [Route("/form")]
    public ActionResult Form1() { return View(); }

    [Route("/results")]
    public ActionResult MadLibsResult(string name1, string name2, string place, string plural1, string plural2, string adjective1, string vehicle, string noun1, string occupation, string fname, string adjective2, string noun2)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Name1 = name1;
      myMadLibsVariable.Name2 = name2;
      myMadLibsVariable.Place = place;
      myMadLibsVariable.PluralNoun1 = plural1;
      myMadLibsVariable.PluralNoun2 = plural2;
      myMadLibsVariable.Adjective1 = adjective1;
      myMadLibsVariable.TypeOfVehicle = vehicle;
      myMadLibsVariable.Noun1 = noun1;
      myMadLibsVariable.Occupation = occupation;
      myMadLibsVariable.FemaleName = fname;
      myMadLibsVariable.Adjective2 = adjective2;
      myMadLibsVariable.Noun2 = noun2;

      return View(myMadLibsVariable);
    }

  }
}