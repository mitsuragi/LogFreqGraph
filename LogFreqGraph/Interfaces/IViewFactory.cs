using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    internal interface IViewFactory
    {
        IGraphView CreateGraphView();
        IAddFunctionView CreateAddFunctionView();
        IMainView CreateMainView();
    }
}
