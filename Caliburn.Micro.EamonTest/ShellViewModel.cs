



namespace Caliburn.Micro.Eamon.WPF
{

    class ShellViewModel : Screen
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

    }
}
