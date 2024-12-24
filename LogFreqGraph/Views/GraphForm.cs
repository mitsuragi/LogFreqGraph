using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;
using SkiaSharp;
using System.Collections.Generic;

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
            questionsBtn.Click += (sender, args) => Invoke(Questions);
        }

        #region "IGraphView Interface Implementation"

        public event Action Return;
        public event Action Questions;
        public event Action UpdateAutoLimits;

        public void SetCharts(List<LogarithmicPoint> points)
        {
            ConfigureGraph(points);

            Graph.Series = Graph.Series.Append(new LineSeries<LogarithmicPoint>
            {
                Mapping = (logPoint, point) => new(logPoint.X, logPoint.Y),
                Values = points,
                LineSmoothness = 0,
                Fill = null,
                XToolTipLabelFormatter = (chartPoint) => string.Format($"X: {chartPoint.Coordinate.SecondaryValue:f3}, Y: {chartPoint.Coordinate.PrimaryValue:f3}")
            });

            for (int i = 1; i < points.Count - 1; i++)
            {
                Graph.Series = Graph.Series.Append(new LineSeries<LogarithmicPoint>
                {
                    Mapping = (logPoint, point) => new(logPoint.X, logPoint.Y),
                    Values = new List<LogarithmicPoint>
                    {
                        new LogarithmicPoint (points[i].X, points[i].Y + 10),
                        new LogarithmicPoint (points[i].X, points[i].Y - 10)
                    },
                    LineSmoothness = 0,
                    Fill = null,
                    GeometrySize = 0,
                    Stroke = new SolidColorPaint(SKColors.Black),
                    IsHoverable = false
                }).ToArray();
            }
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

        private void ConfigureGraph(List<LogarithmicPoint> points)
        {
            Graph.YAxes = new Axis[]
            {
                new Axis
                {
                    SeparatorsPaint = new SolidColorPaint
                    {
                        Color = SKColors.Black.WithAlpha(100),
                        StrokeThickness = 0.5f
                    },
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    Name = "20lgA",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    Labeler = value =>
                    {
                        // Отображаем только кратные 20
                        if (value % 20 == 0)
                        {
                            return value.ToString("F0"); // Целое число без дробной части
                        }
                        return string.Empty; // Не отображать метки для других значений
                    },
                    MinLimit = GetMinYLimit(points),
                    MaxLimit = GetMaxYLimit(points)
                }
            };
            Graph.XAxes = new Axis[]
            {
                new LogaritmicAxis(10)
                {
                    SeparatorsPaint = new SolidColorPaint
                    {
                        Color = SKColors.Black.WithAlpha(100),
                        StrokeThickness = 0.5f
                    },
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    Name = "ω",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    Labeler = value =>
                    {
                        // Проверяем, является ли значение степенью 10
                        var logValue = Math.Log10(value);

                        // Если logValue близко к целому числу (например, 0, 1, 2), отображаем метку
                        if (Math.Abs(logValue - Math.Round(logValue)) < 1e-10)
                        {
                            return $"10^{Math.Round(logValue)}"; // Форматируем как степень 10
                        }

                        // Если значение не является степенью 10, не отображаем метку
                        return string.Empty;
                    },
                    IsVisible = true,
                    MinLimit = 0,
                    MaxLimit = points[^1].X + 1
                }
            };
            Graph.Series = new ISeries[]
            {
                new LineSeries<LogarithmicPoint>
                {
                    Mapping = (logPoint, point) => new(logPoint.X, logPoint.Y),
                    Values = new List<LogarithmicPoint>
                    {
                        new LogarithmicPoint(0, 0),
                        new LogarithmicPoint(points[^1].X + 1, 0)
                    },
                    LineSmoothness = 0,
                    Fill = null,
                    GeometrySize = 0,
                    Stroke = new SolidColorPaint(SKColors.Black, 1.5f),
                    IsHoverable = false
                }
            };
        }

        private double GetMinYLimit(List<LogarithmicPoint> points)
        {
            double result = 100000000;
            foreach (var point in points)
            {
                if (point.Y < result)
                {
                    result = point.Y;
                }
            }
            if (result > 0)
            {
                return -10;
            }
            else
            {
                return result - 10;
            }
        }

        private double GetMaxYLimit(List<LogarithmicPoint> points)
        {
            double result = -100000000;
            foreach (var point in points)
            {
                if (point.Y > result)
                {
                    result = point.Y;
                }
            }

            if (result < 0)
            {
                return 10;
            }
            else
            {
                return result + 10;
            }
        }
    }
}
