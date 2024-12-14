using LogFreqGraph.Models;
using LogFreqGraph.Presenters;
using LogFreqGraph.Views;

namespace LogFreqGraph
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainModel model = new MainModel();

            var presenter = new MainPresenter(new MainForm(), new GraphForm(), model);
            presenter.Run();
        }
    }
}