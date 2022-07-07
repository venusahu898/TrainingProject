using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppHandsOn
{
    internal class networkLog
    {
        public void readNetwork()
        {
            FileStream fileStream = new FileStream(@"C:\Users\VENSAHU\Documents\Visual Studio 2022\Code Snippets\ConsoleApp.NET Framework\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);

            Console.WriteLine("id \t" + "Source \t" + " Destination \t" +
                             "Date \t" + "Time \t" + "Status \t" + "Network");
            while (streamReaderObj.Peek() > 0)
            {
                int i = 0;
                while (i < 6)
                {
                    string line = streamReaderObj.ReadLine();
                    if (line != null)
                        if (line != "")
                        {
                            string[] myStr = line.Split(':');

                            Console.Write(myStr[1] + "\t");
                        }
                    i++;
                }

                Console.WriteLine();
            }
            //Console.WriteLine(streamReaderObj.ReadToEnd());
            Console.Read();
        }
    }
}

