
using System.ComponentModel.Composition;
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



        protected override void OnStartup(object sender, StartupEventArgs e)
        {

            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
