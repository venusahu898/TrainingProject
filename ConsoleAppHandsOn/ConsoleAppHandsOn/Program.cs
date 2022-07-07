using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            networkLog readNetData = new networkLog();
            readNetData.readNetwork();
        }
    }
}
