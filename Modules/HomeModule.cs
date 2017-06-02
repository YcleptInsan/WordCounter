using Nancy;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      Post["/output"] = _ =>{
        string input1 = Request.Form["user_input_form_1"];
        string input2 = Request.Form["user_input_form_2"];

        RepeatCounter newResult = new RepeatCounter(input1, input2);
        int result = newResult.CountRepeats();
        return View["output.cshtml", result];
      };
    }
  }
}
