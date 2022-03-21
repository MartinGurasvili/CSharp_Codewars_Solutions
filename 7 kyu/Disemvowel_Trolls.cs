using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string [] vowels = {"a","i","e","u","o","A","I","E","I","U","O"};
        foreach(string x in vowels)
        {
          str = str.Replace(x,"");
          Console.WriteLine(str);
        }
      
        return str;
    }
}
