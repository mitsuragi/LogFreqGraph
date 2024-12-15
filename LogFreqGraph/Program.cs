using LogFreqGraph.Common;
using LogFreqGraph.Interfaces;
using LogFreqGraph.Models;
using LogFreqGraph.Presenters;
using LogFreqGraph.Views;

namespace LogFreqGraph
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<IMainView, MainForm>()
                .RegisterView<IAddFunctionView, AddFunctionForm>()
                .RegisterView<IGraphView, GraphForm>()
                .RegisterModel<IModel, MainModel>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<MainPresenter>();
        }
    }
}