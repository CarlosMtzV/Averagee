using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Statistics
    {
        public static double CalculateAverage(int[] data)
        {
            double sum = data.Sum();
            return sum / data.Length;
        }

        public static double CalculateAverage(double[] data)
        {
            double sum = data.Sum();
            return sum / data.Length;
        }
    }
}
