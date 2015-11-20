using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.BaseClass
{
    public abstract class PluginBaseClass
    {
        protected PluginBaseClass() {
            var catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new AssemblyCatalog(typeof(IMessageInteface).Assembly));

            var _container = new CompositionContainer(catalog);

            _container.ComposeParts(this);
        }

    }
}
