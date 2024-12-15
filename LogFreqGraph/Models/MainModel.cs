using LogFreqGraph.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Models
{
    public class MainModel : IModel
    {
        private List<TransferFunction> functionsList;
        private double kCoef = 1;

        public MainModel()
        {
            functionsList = new List<TransferFunction>();
            kCoef = 1;
        }

        public void AddTransferFunction(TransferFunction function)
        {
            functionsList.Add(function);
        }

        public void RemoveTransferFunctionAt(int index)
        {
            functionsList.RemoveAt(index);
        }

        public List<TransferFunction> GetFunctionsList()
        {
            return functionsList;
        }

        public double GetCoefficientK()
        {
            return kCoef;
        }

        public void SetCoefficientK(double value)
        {
            kCoef = value;
        }
    }
}
