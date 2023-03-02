using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amogous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            wordGen gen = new wordGen();
            Console.WriteLine("How fast can you type this?");
            string toprint = gen.findSentence();
            Console.WriteLine(toprint);
            Console.ReadLine();
        }
    }
}
