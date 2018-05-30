using ConsoleApp1.Adapter;
using ConsoleApp1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            RoundPeg RP = new RoundPeg(6);
            SquarePeg SP = new SquarePeg(5);
            ConsoleApp1.Source.Adapter.Adapter A = new ConsoleApp1.Source.Adapter.Adapter(SP);
            RoundHole RH = new RoundHole(7);
            Console.WriteLine(RH.fits(A));
           






        }
    }
}
