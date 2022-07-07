using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

/* 1.HANDSON on SERIALIZATION 
Create a class to serialize and deserialize objects in XML format.
To do this you can use the XmlSerialization class included in the System.Xml.Serialization namespace.
First implement a Person class with three properties(Name, Age and City).
Then create a person object and use the XmlSerialization object serializer to
save the data in an xml file,later deserialize the file and print it on screen.
Note: You have to read input from console window and store it in a xml format */

/* 2. Create a class to serialize and deserialize objects in json format. 
 * To do this you can use the JsonSerialization class.
First implement a Person class with three properties (Name, Age and City). 
Then create a person object and use the JsonSerialization object serializer to 
save the data in an xml file, later deserialize the file and print it on screen.
Note: You have to read input from console window and store it in a json format*/

namespace Csharpapplication
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    internal class HandsOnSerial
    {
        public void HOXmlSerialize()
        {
            Person bs = new Person();
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Console.Write("enter name:");
            bs.Name = Console.ReadLine();
            Console.Write("enter age:");
            bs.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter city: ");
            bs.City = Console.ReadLine();

            TextWriter txtWriter = new StreamWriter(@"C:\Training\HOSerialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();

        }
        public void HOXmlDeSerialize()
        {
            Person bs = new Person();
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            StreamReader reader = new StreamReader(@"C:\Training\HOSerialization.xml");
            bs = (Person)xs.Deserialize(reader);
            Console.WriteLine("Person's Details");
            Console.WriteLine("Name: " + bs.Name);
            Console.WriteLine("Age: " + bs.Age);
            Console.WriteLine("City: " + bs.City);

        }

        public void HOJsonSerialize()
        {
            var Person = new Person
            {  
                Name = Console.ReadLine(),
                Age = Convert.ToInt32(Console.ReadLine()),
                City = Console.ReadLine()
            };


            //How to serialize from object to Json
            string jsonString = JsonSerializer.Serialize(Person);
            //How to Deserialize from Json to Object
            var obj = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.City);


        }

    }
}
