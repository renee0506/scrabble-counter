using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrabbleApp.Objects
{
  public class Scrabble
  {

    public char[] inputArray;
    public int result;

    public int Count(string inputWord)
    {
      inputWord.ToUpper();
      inputArray = new char[inputWord.Length];
      inputArray = inputWord.ToCharArray();
      for (int i = 0; i < inputWord.Length; i++)
      {
        if (inputArray[i] == 'A' || inputArray[i] == 'E' || inputArray[i] == 'I' ||inputArray[i] ==  'O' || inputArray[i] == 'U' || inputArray[i] == 'L' || inputArray[i] == 'N' || inputArray[i] == 'R' || inputArray[i] == 'S' || inputArray[i] == 'T')
        {
          result += 1;
        }
        else if (inputArray[i] == 'G' || inputArray[i] == 'D')
        {
          result += 2;
        }
        else if (inputArray[i] == 'B' || inputArray[i] == 'C' || inputArray[i] == 'M' || inputArray[i] == 'P')
        {
          result += 3;
        }
        else if (inputArray[i] == 'F' || inputArray[i] == 'H' || inputArray[i] == 'V' || inputArray[i] == 'W' || inputArray[i] == 'Y')
        {
          result += 4;
        }
        else if (inputArray[i] == 'K')
        {
          result += 5;
        }
        else if (inputArray[i] == 'J' || inputArray[i] == 'X')
        {
          result += 8;
        }
        else if (inputArray[i] == 'Q' || inputArray[i] == 'Z')
        {
          result += 10;
        }
        else
        {
          result += 0;
        }

      }
      return result;
    }

    public int CountDict(string inputWord)
    {
      Regex rgx = new Regex("\\W+");
      inputWord = rgx.Replace(inputWord, "");
      inputArray = new char[inputWord.Length];
      inputArray = inputWord.ToCharArray();
      int result = 0;
      Dictionary<char, int> pairs = new Dictionary<char, int>(){{'A', 1},{'E', 1},{'I', 1},{'O', 1},{'U', 1},{'L', 1},{'N', 1},{'R', 1},{'S', 1},{'T', 1},{'D', 2},{'G', 2}, {'B', 3},{'C', 3},{'M', 3},{'P', 3},{'F', 4},{'H', 4},{'V', 4},{'W', 4},{'Y', 4},{'K', 5},{'J', 8},{'X', 8},{'Q', 10},{'Z', 10}};
      for( int i = 0; i < inputWord.Length; i++ )
      {
        result = result + pairs[inputArray[i]];
      }
      return result;
    }


}
  }
