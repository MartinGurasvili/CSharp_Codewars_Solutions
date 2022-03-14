using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        foreach(char x in str)
        {
          if(new[]{"a","i","e","u","o","A","I","E","U","O"}.Contains(x.ToString()))
          {
            vowelCount+=1;
          }
        }

        return vowelCount;
    }
}
