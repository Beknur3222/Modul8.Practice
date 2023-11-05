using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8.Practice
{
    public class LinearRegression
    {
        public static void CalculateLinearRegression(List<double> x, List<double> y, out double slope, out double intercept)
        {
            if (x.Count != y.Count || x.Count < 2)
            {
                throw new ArgumentException("Invalid input data");
            }

            int n = x.Count;
            double sumX = x.Sum();
            double sumY = y.Sum();
            double sumXY = 0;
            double sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumXY += x[i] * y[i];
                sumX2 += x[i] * x[i];
            }

            slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            intercept = (sumY - slope * sumX) / n;
        }
    }
}
