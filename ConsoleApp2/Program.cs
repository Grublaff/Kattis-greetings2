using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(){
            int toAdd = (Console.ReadLine().Length - 2) * 2;
            List<string> temp = new List<string>();
            temp.Add("h");
            for (int i = 0; i < toAdd; i++)
            {
                temp.Add("e");
            }
            temp.Add("y");
            Console.WriteLine(string.Join("", temp));
        }
    }
}
