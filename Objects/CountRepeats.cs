using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class CountRepeats
  {
    public string GetRepeatTrue(string input1, string input2)
    {
      if(input1 == input2)
      {
        return input1;
      }
      else
      {
        return "not a match";
      }
    }
  }
}
