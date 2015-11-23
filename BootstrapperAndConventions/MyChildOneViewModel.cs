using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BootstrapperAndConventions
{
    [Export(typeof(MyChildOneViewModel))]
    public class MyChildOneViewModel:Screen
    {
        public string Hello
        {
            get;
            private set;
        }
        public MyChildOneViewModel()
        {
            Hello = "hello Word";
        }
    }
}
