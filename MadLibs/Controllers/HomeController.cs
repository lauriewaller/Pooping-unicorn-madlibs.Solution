
using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/hello")]
    // public string Hello() { return "Hello friend!"; }

    // [Route("/goodbye")]
    // public string Goodbye() { return "Goodbye friend."; }

    // [Route("/")]
    // public ActionResult Letter() 
    // { 
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = "Lina";
    //   myLetterVariable.Sender = "Laurie";
    //   return View(myLetterVariable); 
    // }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string pluralNoun1, string adjective1, string animalPluralNoun, string pluralNoun2, string adjective2, string color, string adjective3, string noun1, string pluralNoun3, string adjective4, string verb1, string pluralNoun4, string pastTenseVerb, string verb2, string noun2, string adjective5)
    {
      MadLibsVariable madLibsVariable = new MadLibsVariable();
      madLibsVariable.PluralNoun1 = pluralNoun1;
      madLibsVariable.Adjective1 = adjective1;
      madLibsVariable.AnimalPluralNoun = animalPluralNoun;
      madLibsVariable.PluralNoun2 = pluralNoun2;
      madLibsVariable.Adjective2 = adjective2;
      madLibsVariable.Color  = color;
      madLibsVariable.Adjective3 = adjective3;
      madLibsVariable.Noun1 = noun1;
      madLibsVariable.PluralNoun3 = pluralNoun3;
      madLibsVariable.Adjective4 = adjective4;
      madLibsVariable.Verb1  = verb1;
      madLibsVariable.PluralNoun4  = pluralNoun4;
      madLibsVariable.PastTenseVerb  = pastTenseVerb;
      madLibsVariable.Verb2  = verb2;
      madLibsVariable.Noun2 = noun2 ;
      madLibsVariable.Adjective5  = adjective5;
      return View(madLibsVariable);
    }
  }
}