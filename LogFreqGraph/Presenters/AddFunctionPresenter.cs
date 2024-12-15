using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;
using LogFreqGraph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Presenters
{
    public class AddFunctionPresenter : BasePresenter<IAddFunctionView, IModel>
    {
        private IModel model;

        public AddFunctionPresenter(IApplicationController _controller, IAddFunctionView _view)
            : base(_controller, _view)
        {
            View.AddTransferFunction += AddTransferFunction;
        }

        public override void Run(IModel argument)
        {
            model = argument;
            View.Show();
        }

        private void AddTransferFunction()
        {
            List<double> enumeratorCoefs = View.GetEnumeratorCoefficients();
            List<double> denominatorCoefs = View.GetDenominatorCoefficients();
            double t = View.GetCoefficientT();

            TransferFunction tf = new TransferFunction(enumeratorCoefs, denominatorCoefs, t);
            model.AddTransferFunction(tf);

            View.Close();
        }
    }
}
