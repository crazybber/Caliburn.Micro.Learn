
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Windows;
using Caliburn.Micro.Eamon.WPF.Interface;

namespace Caliburn.Micro.Eamon.WPF
{
    class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize(); //very important 
        }


        private CompositionContainer container;
        protected override void Configure()
        {
            var catalog =
                new AggregateCatalog(
                    AssemblySource.Instance.Select(x => new AssemblyCatalog(x)));


            container = new CompositionContainer(catalog);
            var batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue(container);

            container.Compose(batch);
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            var contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var exports = container.GetExportedValues<object>(contract);

            var enumerable = exports as object[] ?? exports.ToArray();
            if (enumerable.Any())
                return enumerable.First();

            throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType));
        }

        protected override void BuildUp(object instance)
        {
            container.SatisfyImportsOnce(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {

            DisplayRootViewFor<IShell>();
        }
    }
}
