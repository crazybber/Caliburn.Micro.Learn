using System.ComponentModel.Composition;
using Caliburn.Micro.MEF.Demo.Console.BaseClass;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.PluginUser
{
    public class Message2Mgr : PluginBaseClass
    {
        [Import("Client2Message")]
        IMessageInteface msg;

        public void Run()
        {
            msg.Send(" Hello Message2");
        }

    }
}
