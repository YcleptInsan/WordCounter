using Xunit;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_GatherInput_equalTo()
    {
      //Arrange
      string input1 = "french";

      // Act
      CountRepeats newCountRepeats = new CountRepeats();

      //Assert
      Assert.Equal(true , newCountRepeats.GetRepeatTrue(input1));
    }
  }
}
