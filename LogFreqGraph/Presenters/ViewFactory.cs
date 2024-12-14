using LogFreqGraph.Interfaces;
using LogFreqGraph.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Presenters
{
    internal class ViewFactory : IViewFactory
    {
        public IAddFunctionView CreateAddFunctionView()
        {
            return new AddFunctionForm();
        }

        public IGraphView CreateGraphView()
        {
            return new GraphForm();
        }

        public IMainView CreateMainView()
        {
            return new MainForm();
        }
    }
}
