using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class RoundPeg
    {
        private int radius;

        public RoundPeg()
        {

        }

        public RoundPeg(int _radius)
        {
            this.radius = _radius;
        }

        public int getRadius()
        {
            return this.radius;
        }
    }
}
