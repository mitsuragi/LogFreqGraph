﻿using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace LogFreqGraph.Views
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            returnBtn = new Button();
            Graph = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(returnBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(Graph, 0, 0);
            tableLayoutPanel1.Location = new Point(-1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(802, 446);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // returnBtn
            // 
            returnBtn.Anchor = AnchorStyles.Right;
            returnBtn.Location = new Point(705, 411);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(94, 29);
            returnBtn.TabIndex = 0;
            returnBtn.Text = "Назад";
            returnBtn.UseVisualStyleBackColor = true;
            // 
            // Graph
            // 
            Graph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Graph.Location = new Point(3, 3);
            Graph.Name = "Graph";
            Graph.Size = new Size(796, 400);
            Graph.TabIndex = 1;
            Graph.TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Top;
            Graph.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            Graph.YAxes = new Axis[]
            {
                new Axis
                {
                    SeparatorsPaint = new SolidColorPaint
                    {
                        Color = SKColors.Black.WithAlpha(100),
                        StrokeThickness = 1,
                    },
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    Name = "20lgA",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    Labeler = value =>
                    {
                        // Отображаем только кратные 10
                        if (value % 10 == 0)
                        {
                            return value.ToString("F0"); // Целое число без дробной части
                        }
                        return string.Empty; // Не отображать метки для других значений
                    }
                }
            };
            Graph.XAxes = new Axis[]
            {
                new LogaritmicAxis(10)
                {
                    SeparatorsPaint = new SolidColorPaint
                    {
                        Color = SKColors.Black.WithAlpha(100),
                        StrokeThickness = 1
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
                    }
                }
            };
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "GraphForm";
            Text = "GraphForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button returnBtn;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart Graph;
    }
}