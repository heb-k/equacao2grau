using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equacao
{
    class equacao
    {
        public double a = 0, b = 0, c = 0;

        public double delta()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public double x1()
        {
            return (-b + Math.Sqrt(Math.Abs((delta())))) / (2 * a);
        }

        public double x2()
        {
            return (-b - Math.Sqrt(Math.Abs((delta())))) / (2 * a);
        }

    }
}
