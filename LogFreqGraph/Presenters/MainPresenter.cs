using LogFreqGraph.Interfaces;
using LogFreqGraph.Models;

namespace LogFreqGraph.Presenters
{
    internal class MainPresenter : IPresenter
    {
        private readonly IMainView mainView;
        private readonly IGraphView graphView;

        private readonly IViewFactory viewFactory;

        private MainModel model;

        public MainPresenter(IMainView _mainView, IGraphView _graphView, MainModel _model)
        {
            viewFactory = new ViewFactory();

            mainView = _mainView;
            mainView.AddTransferFunction += AddTransferFunction;
            mainView.RemoveTransferFunction += RemoveTransferFunction;
            mainView.RefreshCoefficientK += RefreshCoefficientK;

            graphView = _graphView;

            model = _model;
        }

        public void Run()
        {
            mainView.Show();
        }

        private void AddTransferFunction()
        {
            var addFunctionPresenter = new AddFunctionPresenter(viewFactory.CreateAddFunctionView(), model);

            addFunctionPresenter.Run();

            mainView.SetFunctionsList(model.FunctionsList);
        }

        private void RefreshCoefficientK()
        {
            model.KCoef = mainView.GetCoefficientK();
            mainView.SetCoefficientK(model.KCoef);
        }

        private void RemoveTransferFunction()
        {
            int index = mainView.GetSelectedIndex();
            if (index != -1)
            {
                model.RemoveTransferFunctionAt(index);
            }
            mainView.SetFunctionsList(model.FunctionsList);
        }

        private void PlotGraph()
        {
            throw new NotImplementedException();
        }
    }
}
