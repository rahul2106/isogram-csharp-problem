using System;

namespace isogram_csharp_problem
{
    public class Program
    {
       public static void Main(string[] args)
        {
        }
       public  static bool isIsogram(string str)
        {
           
            int len = str.Length;

            int []a = new int[200];
            for (int i = 0; i < 200; i++)
                a[i] = 0;

            for (int i = 0; i < len - 1; i++)
            {
                if (!Char.IsLetter(str[i]))
                    continue;
                if (a[str[i]] == 0)
                    a[str[i]] = 1;
                else
                    return false;
            }
            return true;
        }
    }
}
