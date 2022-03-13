using System;
public class Kata
{

  public static string High(string s)
  {
    string[] alphabet = new string[]{ "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
    Console.WriteLine(alphabet.Length);
    var words = s.Split();
    int mainindex = 0;
    int index = 0;
    int temp = 0;
    foreach(string word in words)
    {
      int score = 0;
      
      foreach(char letter in word)
      {
          score+=Array.FindIndex(alphabet, m => m == letter.ToString())+1;
      }
      Console.WriteLine(score);
      if(score > temp)
      {
        temp = score;
        mainindex = index;
      }
      index++;
      
    }
    return words[mainindex];
  }
}
