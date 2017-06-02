using System;
using System.Collections.Generic;


namespace WordCounter
{
  public class RepeatCounter
  {
    private string _input1;
    private string _input2;
    private int _count;

    public RepeatCounter(string input1, string input2)
    {
      _input1 = input1;
      _input2 = input2;
    }
    public string GetInput1()
    {
      return _input1;
    }

    public string GetInput2()
    {
      return _input2;
    }
    public int splitInput2()
    {
      string[] input2Array = _input2.Split();
      return input2Array.Length;
    }
    public int CountRepeats()
    {
      //Converts inputs to lowercase
      string input1 = _input1.ToLower();
      input1 = input1.Replace("!", "").Replace(".", "").Replace(",", "").Replace("?", "");
      string input2 = _input2.ToLower();
      input2 = input2.Replace("!", "").Replace(".", "").Replace(",", "").Replace("?", "");
      //Counting through the new Array

       _count = 0;
      string[] input2Array = input2.Split();

      for(int i = 0; i < input2Array.Length; i++)
      {
        if(input1 == input2Array[i])
        {
         _count ++;
        }
      }
      return _count;
    }
  }
}
