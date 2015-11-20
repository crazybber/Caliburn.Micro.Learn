using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.MEF.Demo.Console.BaseClass;
using Caliburn.Micro.MEF.Demo.Console.Interface;

namespace Caliburn.Micro.MEF.Demo.Console.PluginUser
{
    class MultiMessageMgr : PluginBaseClass
    {
        [ImportMany("ClientMessage")]
        IEnumerable<IMessageInteface> msgList;

        public void Run()
        {

            foreach (var item in msgList)
            {
                item.Send("Hello  I am a Loop Message");
            }

        }


    }
}
