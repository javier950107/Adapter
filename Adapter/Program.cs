using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole(5);
            RoundPeg rPeg = new RoundPeg(5);

            Console.WriteLine("Peg hole fits the hole");
            Console.WriteLine(hole.fits(rPeg));

            SquarePeg sPeg = new SquarePeg(5);
            SquarePegAdapter adapter = new SquarePegAdapter(sPeg);

            Console.WriteLine("Square adapter fits the hole");
            Console.WriteLine(hole.fits(adapter));
        }
    }
}
