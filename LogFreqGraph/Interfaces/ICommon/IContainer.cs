using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogFreqGraph.Interfaces
{
    public interface IContainer
    {
        void Register<TModel, TImplemetation>() where TImplemetation : TModel;
        void Register<TModel>();
        void RegisterInstance<T>(T instance);
        TModel Resolve<TModel>();
        bool IsRegistered<TModel>();
        void Register<TModel, TArgument>(Expression<Func<TArgument, TModel>> factory);
    }
}
