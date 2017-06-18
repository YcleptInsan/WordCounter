using Xunit;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_Test1_GatherInputs_equalTo()
    {
      //Arrange
      string input1 = "french";
			string input2 = "french";

      // Act
      RepeatCounter newCountRepeats = new RepeatCounter( input1, input2);

      //Assert
      Assert.Equal(input2 , newCountRepeats.GetInput1());
    }

		[Fact]
    public void RepeatCounter_Test2_SplitInput2Sentence_returnArrayLength()
    {
      RepeatCounter newCountRepeats = new RepeatCounter("I", "I am who I am");

      //Assert
      Assert.Equal(2,  newCountRepeats.CountRepeats());
    }
    [Fact]
    public void RepeatCounter_Test3_SplitInput2Sentence_ReturnWordCount()
    {
      RepeatCounter newCountRepeats = new RepeatCounter("I", "I am who I say I am");

      Assert.Equal(3,  newCountRepeats.CountRepeats());
    }
  }
}
