using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;

namespace LogFreqGraph.Views
{
    public partial class GraphForm : Form, IGraphView
    {
        private readonly ApplicationContext context;

        public GraphForm(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();

            returnBtn.Click += (sender, args) => Invoke(Return);
        }

        #region "IGraphView Interface Implementation"

        public event Action Return;

        public void SetCharts(List<LogarithmicPoint> points)
        {
            Graph.Series = new ISeries[]
            {
                new LineSeries<LogarithmicPoint>
                {
                    Mapping = (logPoint, point) => new (logPoint.X, logPoint.Y),
                    Values = points,
                    LineSmoothness = 0,
                    Fill = null,
                    XToolTipLabelFormatter = (chartPoint) => $"X: {chartPoint.Coordinate.SecondaryValue}, Y: {chartPoint.Coordinate.PrimaryValue}"
                }
            };
        }

        #endregion

        #region "IView Interface Implementation"

        public new void Show()
        {
            ShowDialog();
        }

        public new void Close()
        {
            Dispose();
        }

        #endregion
    }
}
