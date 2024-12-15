using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;
using LogFreqGraph.Models;

namespace LogFreqGraph.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        private IModel model;

        public MainPresenter(IApplicationController _controller, IMainView _view, IModel _model)
            : base(_controller, _view)
        {
            model = _model;

            View.AddTransferFunction += AddTransferFunction;
            View.RemoveTransferFunction += RemoveTransferFunction;
            View.RefreshCoefficientK += RefreshCoefficientK;
            View.PlotGraph += PlotGraph;

            RefreshView();
        }

        private void AddTransferFunction()
        {
            Controller.Run<AddFunctionPresenter, IModel>(model);

            RefreshView();
        }

        private void RefreshCoefficientK()
        {
            model.SetCoefficientK(View.GetCoefficientK());

            RefreshView();
        }

        private void RemoveTransferFunction()
        {
            int index = View.GetSelectedIndex();
            if (index != -1)
            {
                model.RemoveTransferFunctionAt(index);
            }

            RefreshView();
        }

        private void PlotGraph()
        {
            throw new NotImplementedException();
        }
        
        private void RefreshView()
        {
            View.SetCoefficientK(model.GetCoefficientK());
            View.SetFunctionsList(model.GetFunctionsList());
        }
    }
}
