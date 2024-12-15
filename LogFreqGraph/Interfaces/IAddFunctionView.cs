using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    public interface IAddFunctionView : IView
    {
        List<double> GetEnumeratorCoefficients();
        List<double> GetDenominatorCoefficients();
        double GetCoefficientT();

        event Action AddTransferFunction;
    }
}
