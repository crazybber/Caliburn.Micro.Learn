namespace Caliburn.Micro.Eamon.WPF.Windows.ContentWnd
{
    class ContentViewModel : Screen
    {
        public string HelloChild
        {
            get;
            private set;
        }
        public ContentViewModel()
        {
            HelloChild = "hello Word";
        }

    }
}
