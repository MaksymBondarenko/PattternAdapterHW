using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source.Adapter
{
    public class Adapter : iRoundPeg
    {
        SquarePeg peg = null;
        double halfWidth;
        public Adapter(SquarePeg peg)
        {
            this.peg = peg;
        }

        public double getRadius()
        {
            halfWidth = peg.getWidth() / 2;
            return Math.Sqrt(Math.Pow((halfWidth), 2) * 2);
        }
    }
}
