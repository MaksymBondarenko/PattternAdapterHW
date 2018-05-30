using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source
{
   public class SquarePeg
    {
        int Widht { set; get; }
        public SquarePeg(int a)
        {
            Widht = a;
        }
        internal int getWidth()
        {
            return Widht;
        }
    }
}
