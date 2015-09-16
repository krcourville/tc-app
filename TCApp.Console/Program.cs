using CLAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCApp.Cmd
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args == null || !args.Any())
            {
                args = new[] { "h" };
            }

            var actions = new Actions();
            return Parser.RunConsole(args, actions);
        }
    }
}
