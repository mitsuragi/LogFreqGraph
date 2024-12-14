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
            mainView.PlotGraph += PlotGraph;

            graphView = _graphView;

            model = _model;

            RefreshView();
        }

        public void Run()
        {
            mainView.Show();
        }

        private void AddTransferFunction()
        {
            var addFunctionPresenter = new AddFunctionPresenter(viewFactory.CreateAddFunctionView(), model);

            addFunctionPresenter.Run();

            RefreshView();
        }

        private void RefreshCoefficientK()
        {
            model.KCoef = mainView.GetCoefficientK();

            RefreshView();
        }

        private void RemoveTransferFunction()
        {
            int index = mainView.GetSelectedIndex();
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
            mainView.SetCoefficientK(model.KCoef);
            mainView.SetFunctionsList(model.FunctionsList);
        }
    }
}
