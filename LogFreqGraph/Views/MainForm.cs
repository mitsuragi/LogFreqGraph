using LogFreqGraph.Interfaces;
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
        private readonly ApplicationContext context;

        public MainForm(ApplicationContext _context)
        {
            context = _context;

            InitializeComponent();

            graphBtn.Click += (sender, args) => Invoke(PlotGraph);
            addBtn.Click += (sender, args) => Invoke(AddTransferFunction);
            kCoefRefreshBtn.Click += (sender, args) => Invoke(RefreshCoefficientK);
            removeBtn.Click += (sender, args) => Invoke(RemoveTransferFunction);
            aboutBtn.Click += (sender, args) => Invoke(About);
        }

        #region "IMainView interface implementation"

        public event Action AddTransferFunction;
        public event Action RefreshCoefficientK;
        public event Action RemoveTransferFunction;
        public event Action PlotGraph;
        public event Action About;

        public int GetSelectedIndex()
        {
            return functionsListBox.SelectedIndex;
        }
        public double GetCoefficientK()
        {
            double value = 0;
            try
            {
                value = Convert.ToDouble(kTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return double.NaN;
            }
            return value;
        }

        public void SetCoefficientK(double value)
        {
            kInfoLabel.Text = $"Текущее значение коэффициента усиления k: {value}";
        }

        void IMainView.SetFunctionsList(List<TransferFunction> list)
        {
            functionsListBox.Items.Clear();

            foreach (TransferFunction tf in list)
            {
                functionsListBox.Items.Add(tf);
            }
        }

        #endregion

        #region "IView interface implementation"

        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }

        #endregion
    }
}
