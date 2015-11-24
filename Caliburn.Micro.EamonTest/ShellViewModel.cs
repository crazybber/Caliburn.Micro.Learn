



using System.ComponentModel.Composition;
using Caliburn.Micro.Eamon.WPF.Interface;
using Caliburn.Micro.Eamon.WPF.Windows.ContentWnd;

namespace Caliburn.Micro.Eamon.WPF
{
    [Export(typeof(IShell))]

    public class ShellViewModel : PropertyChangedBase, IShell
    {

        readonly IWindowManager myWm;

        public string StrMain
        {
            get;
            private set;
        }

        [ImportingConstructor]
        public ShellViewModel(IWindowManager wm)
        {
            StrMain = "Main!!!!!!";
            myWm = wm;
        }


        private string tbInputName;

        public string TbInputName
        {
            get { return tbInputName; }
            set
            {
                tbInputName = value;

                NotifyOfPropertyChange(() => TbInputName);
                NotifyOfPropertyChange(() => CanOpenSubChildWnd);

            }
        }


        public bool CanOpenSubChildWnd
        {
            get { return !string.IsNullOrWhiteSpace(TbInputName); }
        }


        public void OpenSubChildWnd()
        {

            var _MyChildW = new ContentViewModel();

            myWm.ShowWindow(_MyChildW);
            // MessageBox.Show(string.Format("Hello {0}!", tbInputName)); //Don't do this in real life :)
        }

        public void empty()
        {

            throw new System.NotImplementedException();
        }
    }
}
