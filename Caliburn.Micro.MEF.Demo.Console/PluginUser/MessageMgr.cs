using System.ComponentModel.Composition;
using Caliburn.Micro.MEF.Demo.Console.BaseClass;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.PluginUser
{
    public class MessageMgr : PluginBaseClass
    {
        [Import("ClientMessage")]
        IMessageInteface msg;

        public void Run()
        {
            msg.Send(" Hello Message");
        }

    }
}