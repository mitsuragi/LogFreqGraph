using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogFreqGraph.Presenters
{
    public class GraphPresenter : BasePresenter<IGraphView, IModel>
    {
        private IModel model;

        private List<string> questions = new List<string>
        {
            "1)  В каких единицах измеряется функция  L(ω)  по оси ординат ЛАХ?\r\n",
            "2)  В каких единицах измеряется частота по оси абсцисс ЛАХ?\r\n",
            "3)  В каких единицах откладывается по оси ординат ЛФХ?\r\n",
            "4)  Если ЛАХ и ЛФХ звена представляют собой горизонтальные прямые, то какое это звено?\r\n",
            "5)  Если сопрягающая частота принадлежит апериодическому звену I-го порядка, то как после неё изменится наклон характеристики L(ω)?\r\n",
            "6)  Если сопрягающая частота принадлежит апериодическому звену II-го порядка или колебательному звену, то как после неё изменится наклон характеристики  L(ω)?\r\n",
            "7)  Если сопрягающая частота принадлежит идеальному дифференцирующему звену или форсирующему звену I-го порядка, то как после неё изменится наклон характеристики  L(ω)?\r\n",
            "8)  Если сопрягающая частота принадлежит форсирующему звену II-го порядка, то как после неё изменится наклон характеристики L(ω)?\r\n",
            "9)  Как влияет вид ЛАХ в высокочастотной области на свойства САУ?\r\n",
            "10)  Как выбирается начало координат ЛАХ?\r\n",
            "11)  Как определяется порядок астатизма системы?\r\n",
            "12) Какая область частот ЛАХ диаграммы Боде определяет быстродействие системы?\r\n",
            "13)  Какая область частот ЛАХ диаграммы Боде определяет порядок астатизма и статическую точность системы?\r\n",
            "14)  Какая частота называется частотой сопряжения?\r\n",
            "15)  Какого знака наклон характеристики  L(ω) делают статические звенья?\r\n",
            "16)  Какому диапазону частот диаграммы Боде принадлежит частота среза ωс?\r\n",
            "17)  Установите соответствие между названием типового динамического звена и наклоном (наклонами) асимптотической ЛАХ: \r\nA)  апериодическое звено первого порядка;\r\nB)  консервативное звено;\r\nC)  интегрирующее звено;\r\nD)  дифференцирующее звено.          \r\n          1)  0,  -40 дБ/дек ;       2)  0  и  -20 дБ/дек;       3)  -20 дБ/дек;     \r\n          4)  -20  и  0 дБ/дек;     5)  +20 дБ/дек.\r\n",
            "18)  Чему равен порядок астатизма для статических систем?\r\n",
            "19)  Чему равно число сопрягающих частот?\r\n",
            "20)  Что называется декадой?\r\n"
        };

        private string resultQuestions;

        public GraphPresenter(IApplicationController _controller, IGraphView _view)
            : base(_controller, _view)
        {
            View.Return += OnReturn;
            View.Questions += OnQuestions;
        }

        public override void Run(IModel argument)
        {
            model = argument;
            
            try
            {
                View.SetCharts(model.CalculateLACH());
            }
            catch (Exception ex)
            {
                MessageBox.Show("В двух или более передаточных функциях коэффициент T одинаковый", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            resultQuestions = GetRandomQuestions();

            View.Show();
        }

        private void OnReturn()
        {
            View.Close();
        }
        
        private void OnQuestions()
        {
            MessageBox.Show(resultQuestions, "Вопросы", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private string GetRandomQuestions()
        {
            List<string> randomList = new List<string>();
            Random random = new Random();

            randomList = questions.OrderBy(x => random.Next()).Take(7).ToList();

            string result = "";

            foreach (string question in randomList)
            {
                result += question + '\n';
            }

            return result;
        }
    }
}
