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

        public List<Point2D> CalculateLACH()
        {
            // Определяем диапазон частот (например, от 10^(-2) до 10^2)
            double minFrequency = 0.01;
            double maxFrequency = 100;
            int pointsCount = 1000; // Количество точек для вычислений

            // Логарифмический шаг для частот
            List<double> frequencies = Enumerable.Range(0, pointsCount)
                .Select(i => minFrequency * Math.Pow(maxFrequency / minFrequency, (double)i / (pointsCount - 1)))
                .ToList();

            // Результат: список точек (частота, амплитуда)
            List<Point2D> lachPoints = new List<Point2D>();

            // Вычисляем амплитуду для каждой частоты
            foreach (double omega in frequencies)
            {
                double logAmplitude = 20 * Math.Log10(kCoef); // Начальная амплитуда с учетом коэффициента k

                // Суммируем вклад от каждой передаточной функции
                foreach (var tf in functionsList)
                {
                    double numerator = tf.NumeratorCoeffs
                        .Select((coef, index) => coef * Math.Pow(omega, tf.NumeratorCoeffs.Count - 1 - index))
                        .Sum();
                    double denominator = tf.DenominatorCoeffs
                        .Select((coef, index) => coef * Math.Pow(omega, tf.DenominatorCoeffs.Count - 1 - index))
                        .Sum();

                    double magnitude = Math.Abs(numerator / denominator); // Модуль частотной характеристики
                    logAmplitude += 20 * Math.Log10(magnitude); // Перевод в децибелы
                }

                lachPoints.Add(new Point2D(omega, logAmplitude));
            }

            return lachPoints;
        }
    }
}
