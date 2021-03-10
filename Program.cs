using System;
using System.IO;
using System.Linq;

namespace TZ
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "") break;
                if(s.GroupBy(c => c).Where(c => c.Count() == 2).Count() > 0) Console.WriteLine(s);
            }             
        }
    }
}
