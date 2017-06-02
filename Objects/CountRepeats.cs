using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class CountRepeats
  {
    private string _input1;
    private string _input2;
    private string _result;

    public CountRepeatsInput(string input1, string input2)
    {
      _input1 = input1;
      _input2 = input2;
    }
    public string GetInput1()
    {
      return _input1;
    }
    public void SetInput1(string input1)
    {
      _input1 = input1;
    }
    public string GetInput2()
    {
      return _input2;
    }
    public void SetInput2(string input2)
    {
      _input2 = input2;
    }
    public string GetResult()
    {
      return _result;
    }
    public void SetResult(string result)
    {
      _result = result;
    }
    public CountRepeats(string input1, string input2)
    {

    }
    //CONVERTS INPUT FROM FORM 2 INTO a list of string in an array separated by whitespace.
    public string CompareStringArray(string input1, string input2)
    {
      input1 = input1.ToLower();
      input2 = input2.ToLower();
      List<string> newList = new List<string>();
      string[] StringArray = input2.Split(' ');
      foreach(string word in StringArray){
        newList.Add(word);
      }
      if (newList.Contains(input1))
        {
            Console.WriteLine("3.5 " + newList[0]);
            Console.WriteLine("match");
        }
      return "result";
    }
  }
}
