using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SquarePeg
    {
        private int width;

        public SquarePeg(int _width) {
            this.width = _width;
        }

        public int getWidth()
        {
            return width;
        }
    }
}
