﻿using LogFreqGraph.Interfaces;
using LogFreqGraph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFreqGraph.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();

            addBtn.Click += (sender, args) => Invoke(AddTransferFunction);
            kCoefRefreshBtn.Click += (sender, args) => Invoke(RefreshCoefficientK);
            removeBtn.Click += (sender, args) => Invoke(RemoveTransferFunction);
            graphBtn.Click += (sender, args) => Invoke(PlotGraph);
        }

        #region "IMainView interface implementation"

        public event Action AddTransferFunction;
        public event Action RefreshCoefficientK;
        public event Action RemoveTransferFunction;
        public event Action PlotGraph;

        public int GetSelectedIndex()
        {
            return functionsListBox.SelectedIndex;
        }
        public double GetCoefficientK()
        {
            return Convert.ToDouble(kTextBox.Text);
        }

        public void SetCoefficientK(double value)
        {
            kTextBox.Text = $"Текущее значение коэффициента k:{value}";
        }

        void IMainView.SetFunctionsList(List<TransferFunction> list)
        {
            foreach (TransferFunction tf in list)
            {
                functionsListBox.Items.Add(tf);
            }
        }

        #endregion

        #region "IView interface implementation"

        public new void Show()
        {
            Application.Run(this);
        }

        #endregion
    }
}