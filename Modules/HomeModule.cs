using System;
using Nancy;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };


    }
  }
}
