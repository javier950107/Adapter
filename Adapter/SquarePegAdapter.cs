using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg _squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            this._squarePeg = squarePeg;
        }


        public int getRadius(SquarePeg peg)
        {
            return (int)(peg.getWidth() * Math.Sqrt(2) / 2);
        }
    }
}
