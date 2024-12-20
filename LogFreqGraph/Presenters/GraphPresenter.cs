using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Presenters
{
    public class GraphPresenter : BasePresenter<IGraphView, IModel>
    {
        private IModel model;

        public GraphPresenter(IApplicationController _controller, IGraphView _view)
            : base(_controller, _view)
        {
            View.Return += OnReturn;
        }

        public override void Run(IModel argument)
        {
            model = argument;

            View.SetCharts(model.CalculateLACH());

            View.Show();
        }

        private void OnReturn()
        {
            View.Close();
        }
    }
}
