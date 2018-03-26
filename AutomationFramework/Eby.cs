using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    public class Eby
    {
        delegate int DoSmsth(int x, int y);

        public static void Sandbox()
        {
            DoSmsth doSmsth = (x, y) => { Console.WriteLine(x + y); return 40; };
            doSmsth(5, 5);
            doSmsth = (x, y) => { Console.WriteLine(x * 2 + y/10); return 40; };
            doSmsth(5,10);
        }
    }



}
