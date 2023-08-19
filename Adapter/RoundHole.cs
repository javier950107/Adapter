using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class RoundHole
    {
        private int _radius;

        public RoundHole(int _radius)
        {
            this._radius = _radius;
        }

        public int getRadius()
        {
            return this._radius;
        }

        public bool fits(RoundPeg peg)
        {
            return this.getRadius() >= peg.getRadius();
        }
    }
}

