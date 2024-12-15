using LogFreqGraph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    public interface IModel
    {
        void AddTransferFunction(TransferFunction function);
        void RemoveTransferFunctionAt(int index);
        List<TransferFunction> GetFunctionsList();
        double GetCoefficientK();
        void SetCoefficientK(double value);
    }
}
