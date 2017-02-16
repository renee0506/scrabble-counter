
using Xunit;
using System.Collections.Generic;
using ScrabbleApp.Objects;

namespace ScrabbleApp
{
  public class ScrabbleTest
  {
    [Fact]
    public void Scrabble_InputAEIOULNRST_1()

    {
      //Arrange
      Scrabble obj = new Scrabble();


      //Act
      int output = obj.Count("T");

      //Assert
      Assert.Equal(1, output);
    }

    [Fact]
    public void Scrabble_InputDG_2()
    {
      //Arrange
      Scrabble obj = new Scrabble();


      //Act
      int output = obj.Count("QUIZ");

      //Assert
      Assert.Equal(22, output);
    }

    [Fact]
    public void ScrabbleDict_InputAEIOULNRST_1()

    {
      //Arrange
      Scrabble obj = new Scrabble();


      //Act
      int output = obj.CountDict("T");

      //Assert
      Assert.Equal(1, output);
    }

    [Fact]
    public void ScrabbleDict_InputDG_2()
    {
      //Arrange
      Scrabble obj = new Scrabble();


      //Act
      int output = obj.CountDict("QUIZ");

      //Assert
      Assert.Equal(22, output);
    }
  }
}
