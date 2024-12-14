using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Models
{
    internal class MainModel
    {
        private List<TransferFunction> functionsList;
        private double kCoef;
        public List<TransferFunction> FunctionsList
        {
            get => functionsList;
            set => functionsList = value;
        }
        public double KCoef
        {
            get => kCoef;
            set => kCoef = value;
        }

        public MainModel()
        {
            functionsList = new List<TransferFunction>();
            kCoef = 1;
        }

        public void AddTransferFunction(TransferFunction function)
        {
            functionsList.Add(function);
        }

        public void RemoveTransferFunction(TransferFunction function)
        {
            functionsList.Remove(function);
        }

        public void RemoveTransferFunctionAt(int index)
        {
            functionsList.RemoveAt(index);
        }
    }
}
