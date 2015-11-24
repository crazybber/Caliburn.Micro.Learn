



using System.ComponentModel.Composition;
using Caliburn.Micro.Eamon.WPF.Interface;

namespace Caliburn.Micro.Eamon.WPF
{
    [Export(typeof(IShell))]

    public class ShellViewModel : PropertyChangedBase, IShell
    {

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


            // MessageBox.Show(string.Format("Hello {0}!", tbInputName)); //Don't do this in real life :)
        }

        public void empty() {

            throw new System.NotImplementedException();
        }
    }
}
