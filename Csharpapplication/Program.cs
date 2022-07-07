using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Csharpapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandsOnSerial handsOnSerial = new HandsOnSerial();
            handsOnSerial.HOJsonSerialize();
            Console.Read();
            /* 1.handsOnSerial.HOXmlSerialize();
            handsOnSerial.HOXmlDeSerialize();*/

            /*SerializationDemo serializeonDemo = new SerializationDemo();
             //serializeonDemo.XmlDeSerialize();
             serializeonDemo.JsonSerialize(); */

            /* GenericsDemo genericsDemo = new GenericsDemo();
             genericsDemo.ShowsalaryReport(400.20);
             genericsDemo.ShowAgeReport(23);
             genericsDemo.ShowGenderReport("female");*/


            /*Movie selectObj = new Movie();
            selectObj.SelectMovies();

            Movie movieObj = new Movie();
            Console.WriteLine("Enter MovieId: ");
            int movieId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MovieName: ");
            String movieName = Console.ReadLine();
            Console.WriteLine("Enter MovieDesc: ");
            String movieDesc = Console.ReadLine();
            Console.WriteLine("Enter MovieLanguage: ");
            String movieLanguage = Console.ReadLine();
            movieObj.CreateMovie(movieId,movieName, movieDesc, movieLanguage );
            Console.WriteLine(" show :", movieId, movieName, movieDesc, movieLanguage); */

            //int a,b,c;
            //Console.WriteLine("Enter value a: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value b: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //ReadLine reads input and moves to next line while Read reads input in same line.
            //Console.WriteLine("sum of a and b is: ");
            //c = a + b;
            //How to Print/Display output
            //Console.WriteLine(c);

            //for(int j = 0; j < 5; j++)
            /*{
                Console.WriteLine(j);
            } */
            //in the left corner line click for break line
            /*Employee eventObj = new Employee();
           
            eventObj.CreateEvents();
            eventObj.SelectEvents();
            Console.Read(); //How to read keyboard input?

            Customers customerObj = new Customers();
            customerObj.CreateEvents();*/
        }
    }
}
