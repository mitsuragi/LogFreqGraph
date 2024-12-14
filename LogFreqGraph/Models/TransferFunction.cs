using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Models
{
    internal class TransferFunction
    {
        private List<double> enumeratorCoeffs;
        private List<double> denominatorCoeffs;
        private double tCoef;

        public List<double> EnumeratorCoeffs
        {
            get => enumeratorCoeffs;
            set => enumeratorCoeffs = value;
        }
        public List<double> DenominatorCoeffs
        {
            get => denominatorCoeffs;
            set => denominatorCoeffs = value;
        }
        public double TCoef
        {
            get => tCoef;
            set => tCoef = value;
        }

        public TransferFunction(List<double> ec, List<double> dc, double t)
        {
            enumeratorCoeffs = ec;
            denominatorCoeffs = dc;
            tCoef = t;
        }
    }
}
