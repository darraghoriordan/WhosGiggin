using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using WhosGiggin.DataContext;
using Ninject.Modules;

namespace WhosGiggin
{
    public class DIConfig
    {
        public static IKernel GetKernel()
        {
            var modules = new NinjectModule[] { new DataContextModule() };
            return new StandardKernel(modules);
        }
    }

    public class DataContextModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUOW>().To<UOW>();
        }


    }
}