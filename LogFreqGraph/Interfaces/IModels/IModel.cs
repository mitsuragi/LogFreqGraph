using LogFreqGraph.Models;
using LogFreqGraph.Common;

namespace LogFreqGraph.Interfaces
{
    public interface IModel
    {
        void AddTransferFunction(TransferFunction function);
        void RemoveTransferFunctionAt(int index);
        List<TransferFunction> GetFunctionsList();
        double GetCoefficientK();
        void SetCoefficientK(double value);
        List<Point2D> CalculateLACH();
    }
}
