using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraunhoferDiffractionThroughMultipleSlits
{
#pragma warning disable IDE1006
    public sealed record Calculator(double A0, double a, int N, double b, double Lambda)
#pragma warning restore IDE1006
    {
        private static double Square(double value) => value * value;

        public double ITheta(double sinTheta)
        {
            var d = a + b;
            var delta = 2 * Math.PI * d * sinTheta / Lambda;
            var alpha = Math.PI * a * sinTheta / Lambda;
            return Square(A0 *
                (Math.Sin(alpha) / alpha) *
                (Math.Sin(N * delta / 2) / Math.Sin(delta / 2)));
        }
    }
}
