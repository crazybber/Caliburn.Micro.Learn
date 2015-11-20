using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro.MEF.Demo.Console.BaseClass;
using Caliburn.Micro.MEF.Demo.Console.Interface;
using Caliburn.Micro.MEF.Demo.Console.Template;

namespace Caliburn.Micro.MEF.Demo.Console.PluginUser
{
    class MultiMessageMgrWithDepictUsingLayMode 
    {

        public MultiMessageMgrWithDepictUsingLayMode()
        {
            this.ComposePartsSelf();
        }

        [ImportMany("ClientMessageWithDepict")]
        IEnumerable<Lazy<IMessageInteface, IMessageIterfaceeDepict>> msg_list;

        public void Run()
        {

            foreach (var item in msg_list.Where(_item => _item.Metadata.DepictContent == ReadXml()))
            {
                item.Value.Send("Hello MultiMessageMgrWithDepictUsingLayMode");
            }
        }

        string ReadXml()
        {
            return "2";
        }
    }
}
