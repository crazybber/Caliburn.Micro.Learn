using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.MEF.Demo.Console.Interface;
using Caliburn.Micro.MEF.Demo.Console.PluginUser;

namespace Caliburn.Micro.MEF.Demo.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            var demo = new MessageMgr();
            var demo2 = new Message2Mgr();
            var demo3 = new MultiMessageMgr();
            var demo4 = new MultiMessageMgrWithDepictUsingLayMode();

            demo.Run();
            demo2.Run();
            demo3.Run();
            demo4.Run();
            System.Console.Read();

        }
    }
}
