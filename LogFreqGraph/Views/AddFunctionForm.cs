using LogFreqGraph.Interfaces;
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
    public partial class AddFunctionForm : Form, IAddFunctionView
    {
        public AddFunctionForm()
        {
            InitializeComponent();

            submitBtn.Click += (sender, args) => Invoke(AddTransferFunction);
        }

        #region "IAddFunctionView implementation"

        public event Action AddTransferFunction;

        public double GetCoefficientT()
        {
            return Convert.ToDouble(tCoefTextBox.Text);
        }

        public List<double> GetDenominatorCoefficients()
        {
            return new List<double>(Array.ConvertAll(
                denominatorTextBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries),
                double.Parse));
        }

        public List<double> GetEnumeratorCoefficients()
        {
            return new List<double>(Array.ConvertAll(
                enumeratorTextBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries),
                double.Parse));
        }
        #endregion

        #region "IView implementation"
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
