using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var str = Console.ReadLine();
        var q = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < q; i++)
        {           
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[1]);
            int y = int.Parse(input[2]);
            
            if (input[0] == "replace")
            {
                var Rinput = new List<char>();
                var replace = new List<char>();
                foreach(char c in input[3])
                {
                    Rinput.Add(c);
                }
                int num = Rinput.Count;
                foreach(char c in str)
                {
                    replace.Add(c);
                }
                for(int j = 0; j < num; j++)
                {
                    replace[x + j] = Rinput[j];
                }
                str = string.Join("", replace);
            }
            else if (input[0] == "reverse")
            {
                List<char> list = new List<char>();
                foreach(char c in str)
                {
                    list.Add(c);
                }
                list.Reverse(x, y - x + 1);
                str = string.Join("", list.ToArray());
             
            }
            else if (input[0] == "print")
            {
                Console.WriteLine(str.Substring(x, y - x + 1));
            }
            
        }
    }
}