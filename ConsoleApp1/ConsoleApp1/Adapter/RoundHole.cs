using ConsoleApp1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    public class RoundHole
    {
        int radius;
        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public int getRadius()
        {
            return radius;
        }

        public bool fits(iRoundPeg peg)
        {
            if (this.radius > peg.getRadius())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
