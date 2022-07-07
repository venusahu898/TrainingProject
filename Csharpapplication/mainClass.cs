using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Csharpapplication
{
    internal class mainClass
    {
        static void Main(string[] args)
        {
            SerializationDemo serializetoDemo = new SerializationDemo();
            serializetoDemo.XmlSerialize();
        }
    }
}
