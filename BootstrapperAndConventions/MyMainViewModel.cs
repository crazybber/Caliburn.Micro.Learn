using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BootstrapperAndConventions
{
    [Export(typeof(IShell))]
    public class MyMainViewModel
    {
        readonly IWindowManager _myWM;
        public string StrMain
        {
            get;
            private set;
        }
        [ImportingConstructor]
        public MyMainViewModel(IWindowManager wm)
        {
            StrMain = "Main!!!!!!";
            _myWM = wm;
        }
        MyChildOneViewModel _MyChildW = new MyChildOneViewModel();
        public void OpenOneChild()
        {
            
            _myWM.ShowDialog(_MyChildW);
        }
    }
}
