using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Models
{
    public class TransferFunction
    {
        private List<double> numeratorCoeffs;
        private List<double> denominatorCoeffs;
        private double tCoef;
        private bool isIntegral;
        private bool isPureDif;

        public List<double> NumeratorCoeffs
        {
            get => numeratorCoeffs;
            set => numeratorCoeffs = value;
        }
        public List<double> DenominatorCoeffs
        {
            get => denominatorCoeffs;
            set => denominatorCoeffs = value;
        }
        public double TCoef
        {
            get => tCoef;
            set => tCoef = value;
        }
        public bool IsIntegral
        {
            get => isIntegral;
            set => isIntegral = value;
        }
        public bool IsPureDif
        {
            get => isPureDif;
            set => isPureDif = value;
        }

        public TransferFunction(List<double> nc, List<double> dc, double t)
        {
            numeratorCoeffs = nc;
            denominatorCoeffs = dc;
            tCoef = t;
            if (nc.Count == 1 && IsOnlyOneNotZero(dc) == true)
            {
                isIntegral = true;
            }
            if (dc.Count == 1 && IsOnlyOneNotZero(nc) == true)
            {
                isPureDif = true;
            }
        }

        public override string ToString()
        {
            StringBuilder numerator = new StringBuilder();
            StringBuilder denominator = new StringBuilder();

            // Формирование числителя
            for (int i = 0; i < numeratorCoeffs.Count; i++)
            {
                double coef = numeratorCoeffs[i] * Math.Pow(tCoef, numeratorCoeffs.Count - 1 - i);
                int power = numeratorCoeffs.Count - 1 - i;

                if (coef == 0) continue;

                if (numerator.Length > 0)
                    numerator.Append(coef > 0 ? " + " : " - ");
                else if (coef < 0)
                    numerator.Append("-");

                double absCoef = Math.Abs(coef);
                if (absCoef != 1 || power == 0)
                    numerator.Append(absCoef);

                if (power > 0)
                    numerator.Append("s");
                if (power > 1)
                    numerator.Append("^" + power);
            }

            // Формирование знаменателя
            for (int i = 0; i < denominatorCoeffs.Count; i++)
            {
                double coef = denominatorCoeffs[i] * Math.Pow(tCoef, denominatorCoeffs.Count - 1 - i);
                int power = denominatorCoeffs.Count - 1 - i;

                if (coef == 0) continue;

                if (denominator.Length > 0)
                    denominator.Append(coef > 0 ? " + " : " - ");
                else if (coef < 0)
                    denominator.Append("-");

                double absCoef = Math.Abs(coef);
                if (absCoef != 1 || power == 0)
                    denominator.Append(absCoef);

                if (power > 0)
                    denominator.Append("s");
                if (power > 1)
                    denominator.Append("^" + power);
            }

            // Формирование итогового результата
            if (denominatorCoeffs.Count == 1 && denominatorCoeffs[0] == 1)
            {
                return numerator.ToString();
            }
            else if (denominator.Length > 0)
            {
                return numerator.Length > 0
                    ? $"{numerator} / ({denominator})"
                    : $"1 / ({denominator})";
            }
            else
            {
                return numerator.ToString();
            }
        }

        private bool IsOnlyOneNotZero(List<double> coeffs)
        {
            if (coeffs.Count == 1) return true;

            int counter = 0;
            foreach ( double coefficient in coeffs)
            {
                if (coefficient == 0) continue;
                counter++;
            }

            if (counter > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
