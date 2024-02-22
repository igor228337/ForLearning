using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.PhysicLogic
{
    internal class PifagorMethod
    {
        static double CalculateHypotenuse(int a, int b, int angel)
        {
            double c = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * b * a) * Math.Cos(angel);
            return Math.Sqrt(c);
        }
    }
}
