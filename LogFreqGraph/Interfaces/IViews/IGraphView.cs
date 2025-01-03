﻿using LiveChartsCore.Easing;
using LogFreqGraph.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    public interface IGraphView : IView
    {
        void SetCharts(List<LogarithmicPoint> points);

        event Action Return;
        event Action Questions;
        event Action UpdateAutoLimits;
    }
}
