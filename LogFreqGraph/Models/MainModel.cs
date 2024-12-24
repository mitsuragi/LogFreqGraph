using LogFreqGraph.Common;
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

        public List<LogarithmicPoint> CalculateLACH()
        {
            List<LogarithmicPoint> lachList = [];

            Dictionary<double, TransferFunction> freqFuncDict = [];
            List<double> frequencies = [];
            int incline = 0;
            int n = 0;
            
            for (int i = 0; i < functionsList.Count; i++)
            {
                if (functionsList[i].IsPureDif)
                {
                    n += Math.Abs(functionsList[i].NumeratorCoeffs.Count - functionsList[i].DenominatorCoeffs.Count);
                    continue;
                }
                if (functionsList[i].IsIntegral)
                {
                    n -= Math.Abs(functionsList[i].NumeratorCoeffs.Count - functionsList[i].DenominatorCoeffs.Count);
                    continue;
                }
                double frequency = 1 / functionsList[i].TCoef;

                frequencies.Add(frequency);

                freqFuncDict.Add(frequency, functionsList[i]);
            }

            frequencies.Sort();
            frequencies.Add(frequencies[^1] * 1.5);

            double Y = 20 * Math.Log10(kCoef);

            lachList.Add(new LogarithmicPoint(0, Y));
            incline += 20 * n;

            if (incline != 0)
            {
                if (frequencies[0] == 1)
                {
                    Y += incline;
                }
                else
                {
                    Y += incline * Math.Log10(frequencies[0]);
                }
            }

            lachList.Add(new LogarithmicPoint(frequencies[0], Y));


            for (int i = 1; i < frequencies.Count; i++)
            {
                double omega = frequencies[i - 1];
                TransferFunction func = freqFuncDict.GetValueOrDefault(omega);

                incline += (func.NumeratorCoeffs.Count - func.DenominatorCoeffs.Count) * 20;
                
                if (incline > 0)
                {
                    Y -= incline * (Math.Log10(frequencies[i - 1]) - Math.Log10(frequencies[i]));
                }
                else if (incline < 0)
                {
                    Y += incline * (Math.Log10(frequencies[i]) - Math.Log10(frequencies[i - 1]));
                }

                lachList.Add(new LogarithmicPoint(frequencies[i], Y));
            }

            return lachList;
        }
    }
}
