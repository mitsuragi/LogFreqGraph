using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Common
{
    public class LogarithmicPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public LogarithmicPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
