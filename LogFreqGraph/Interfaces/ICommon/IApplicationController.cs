﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterInstance<TInstance>(TInstance instance);

        IApplicationController RegisterModel<TModel, TImplementation>()
            where TImplementation : class, TModel;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgument>(TArgument argument)
            where TPresenter : class, IPresenter<TArgument>;
    }
}
