using LogFreqGraph.Interfaces;
using LogFreqGraph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Presenters
{
    internal class AddFunctionPresenter : IPresenter
    {
        private readonly IAddFunctionView addFunctionView;
        private MainModel model;

        public AddFunctionPresenter(IAddFunctionView _addFunctionView, MainModel _model)
        {
            addFunctionView = _addFunctionView;
            addFunctionView.AddTransferFunction += AddTransferFunction;

            model = _model;
        }

        public void Run()
        {
            addFunctionView.Show();
        }

        private void AddTransferFunction()
        {
            List<double> enumeratorCoefs = addFunctionView.GetEnumeratorCoefficients();
            List<double> denominatorCoefs = addFunctionView.GetDenominatorCoefficients();
            double t = addFunctionView.GetCoefficientT();

            TransferFunction tf = new TransferFunction(enumeratorCoefs, denominatorCoefs, t);
            model.AddTransferFunction(tf);

            addFunctionView.Close();
        }
    }
}
