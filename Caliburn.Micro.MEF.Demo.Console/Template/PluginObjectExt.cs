using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.Template
{
    public static class PluginObjectExt
    {
        public static T ComposePartsSelf<T>(this T obj) where T : class
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog("."));
            var _container = new CompositionContainer(catalog);
            _container.ComposeParts(obj);
            return obj;
        }


    }
}
