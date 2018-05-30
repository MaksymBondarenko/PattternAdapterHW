using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source
{

    public class RoundPeg : iRoundPeg
    {
        double radius;
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
    }
}
