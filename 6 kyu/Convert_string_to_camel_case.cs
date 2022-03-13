using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    string[] temp = str.Split('_');
    string[] temp2 = String.Join(" ", temp).Split('-');
    string[] words = String.Join(" ", temp2).Split(' ');
    string end = "";
    bool count = true;
    foreach(string w in words)
    {
      if(count)
      {
        end = w;
        count = false;
      }
      else
      {
        end = end+((w[0]).ToString().ToUpper()+w.Remove(0, 1));
      }
      
    }
    return end;
  }
}
