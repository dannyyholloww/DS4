using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_12.3
{
    internal class Calculos
    {
        public double SemiPerimetro(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        public double AreaTriangulo(double a, double b, double c)
        {
            double sp = SemiPerimetro(a, b, c);
            double ans = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            return ans;
        }

    }
}