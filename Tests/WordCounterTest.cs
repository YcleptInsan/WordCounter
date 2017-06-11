using Xunit;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterTest1_GatherInputs_equalTo()
    {
      //Arrange
      string input1 = "french";
			string input2 = "french";

      // Act
      RepeatCounter newCountRepeats = new RepeatCounter( input1, input2);

      //Assert
      Assert.Equal(input2 , newCountRepeats.GetInput1());


    // [Fact]
    // public void RepeatCounterTest2_GatherInputs_CompairToString()
    // {
    //   //Arrange
    //   string input1 = "french";
    //   List<string> input2 = new List<string>();
    //   input2.Add("jenny");
    //   input2.Add("was");
    //   input2.Add("just");
    //   input2.Add("about");
    //   input2.Add("french");
		//
    //   foreach (string match in input2)
    //   {
    //     if (match == input1)
    //     {
    //       System.Console.WriteLine("match");
    //     }
    //     else
    //     {
    //       System.Console.WriteLine("not quite");
    //     }
      // }
    }
  }
}
