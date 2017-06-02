using System;
using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        RepeatCounter instance = new RepeatCounter(Request.Form["corpus"], Request.Form["search-terms"]);
        return View["index.cshtml", instance.CountRepeats()];
      };
    }
  }
}
