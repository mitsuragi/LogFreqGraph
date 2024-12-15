using LiveChartsCore.Easing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    public interface IGraphView : IView
    {
        void SetCharts();

        event Action Return;
    }
}
