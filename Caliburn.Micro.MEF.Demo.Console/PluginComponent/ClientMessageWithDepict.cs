using System.ComponentModel.Composition;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.PluginComponent
{
    [Export("ClientMessageWithDepict", typeof(IMessageInteface))]
    [ExportMetadata("DepictContent", "2")]
    class ClientMessageWithDepict:IMessageInteface
    {

        public void Send(string message) {

            System.Console.WriteLine("I am ClientMessageWithDepict ,I send a Messsage :{0}", message);
        }
    }
}
