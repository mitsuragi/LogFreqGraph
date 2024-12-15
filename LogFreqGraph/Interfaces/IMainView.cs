using LogFreqGraph.Models;

namespace LogFreqGraph.Interfaces
{
    public interface IMainView : IView
    {
        void SetFunctionsList(List<TransferFunction> list);
        void SetCoefficientK(double value);
        double GetCoefficientK();
        int GetSelectedIndex();


        event Action AddTransferFunction;
        event Action RemoveTransferFunction;
        event Action RefreshCoefficientK;
        event Action PlotGraph;
    }
}