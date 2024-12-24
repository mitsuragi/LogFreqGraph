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
            List<double> enumeratorCoefs;
            List<double> denominatorCoefs;
            double t;

            try
            {
                enumeratorCoefs = View.GetEnumeratorCoefficients();
                denominatorCoefs = View.GetDenominatorCoefficients();
                t = View.GetCoefficientT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (t == double.NaN || enumeratorCoefs.Count == 0 || denominatorCoefs.Count == 0)
            //{
            //    return;
            //}

            TransferFunction tf = new TransferFunction(enumeratorCoefs, denominatorCoefs, t);
            model.AddTransferFunction(tf);

            View.Close();
        }
    }
}
