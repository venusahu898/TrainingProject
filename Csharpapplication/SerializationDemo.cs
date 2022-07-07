using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;

namespace Csharpapplication
{
    public class WeatherForecast
        {
          public DateTimeOffset Date { get; set;  }
          public int TemperatureCelcius { get; set; }
          public string Summary { get; set; }
        }
    public class Employees
    {
      public  int id = 1;
       public string name = "Venu";
       public string subject = "Physics";


    }
    
    internal class SerializationDemo
    {
        public void JsonSerialize()
        {
            var WeatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelcius = 25,
                Summary = "Hot"
            };
            //The above lines can be written as below, but above one is more efficient.
            /* WeatherForecast obj= new WeatherForecast();
            obj.Date = DateTime.Now;
            obj.TemperatureCelcius = 20;
            obj.Summary = "cool"; */
             
            //How to serialize from object to Json
            string jsonString = JsonSerializer.Serialize(WeatherForecast);
            //How to Deserialize from Json to Object
            var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine(obj.Date);
            Console.WriteLine(obj.TemperatureCelcius);
            Console.WriteLine(obj.Summary);


        }
        public void XmlSerialize()
        {
            Employees bs= new Employees();
            XmlSerializer xs = new XmlSerializer(typeof(Employees));
            TextWriter txtWriter = new StreamWriter(@"C:\Training\Serialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();

        }
        public void XmlDeSerialize()
        {
            Employees bs = new Employees();
            XmlSerializer xs = new XmlSerializer(typeof(Employees));
            StreamReader reader = new StreamReader(@"C:\Users\VENSAHU\Documents\Visual Studio 2022\Code Snippets\ConsoleApp.NET Framework\Serialization.xml");
            bs = (Employees)xs.Deserialize(reader);
            Console.WriteLine("employees Details");
            Console.WriteLine("ID: " + bs.id);
            Console.WriteLine("Name: " + bs.name);
            Console.WriteLine("subject: " + bs.subject);

        }

    }

    internal class GenericsDemo //class
    {    
        //With normal Class and Function creating Method, adding another function is lengthy and time taking.
        //Insted use generic type for the fuction creation
        
        public void ShowReport<T>(T value)
        {
            Console.WriteLine(value);
        }
        public void ShowAgeReport(int age)   //function 1
        {
            Console.WriteLine(age);
        }   
        public void  ShowGenderReport(string gender) //function 2
        {
            Console.WriteLine(gender);
        }
        public void ShowsalaryReport(double salary)   //function 3
        {
            Console.WriteLine(salary);
        }
    }
    
}
