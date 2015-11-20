using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.PluginComponent
{
    [Export("ClientMessage", typeof(IMessageInteface))]
    [ExportMetadata("DepictContent", "1")]
    public class ClientMessage : IMessageInteface
    {
        public void Send(string message)
        {

            System.Console.WriteLine("i am Client ,I Send u a Message:{0}", message);
            // throw new NotImplemen"tedException();
        }
    }
}
