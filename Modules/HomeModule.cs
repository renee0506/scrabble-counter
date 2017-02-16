
using Nancy;
using System;
using System.Collections.Generic;
using ScrabbleApp.Objects;

namespace ScrabbleModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ => {
        string input = Request.Form["user-input"];
        Scrabble newScrabble = new Scrabble();
        int score = newScrabble.CountDict(input);
        return View["result.cshtml", score];
      };
    }
  }
}
