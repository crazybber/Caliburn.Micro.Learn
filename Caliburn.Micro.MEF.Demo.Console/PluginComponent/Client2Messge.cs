using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.PluginComponent
{

[Export("Client2Message",typeof(IMessageInteface))]
[ExportMetadata("DepictContent", "2")]
  public  class Client2Messge:IMessageInteface
    {

      public void Send(string message) {
          System.Console.WriteLine("i am Client2 ,I Send u a Message: {0}", message);
      }
  }
}
