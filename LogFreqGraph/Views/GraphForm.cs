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
    public partial class GraphForm : Form, IGraphView
    {
        private readonly ApplicationContext context;

        public GraphForm(ApplicationContext _context)
        {
            context = _context;

            InitializeComponent();
        }

        #region "IGraphView Interface Implementation"

        public event Action Return;

        public void SetCharts()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region "IView Interface Implementation"

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        #endregion
    }
}
