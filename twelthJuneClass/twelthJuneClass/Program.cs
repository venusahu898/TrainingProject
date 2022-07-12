using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twelthJuneClass
{
    internal class Program
    {
        //select * from tablename where group by having order
        static void Main(string[] args)
        {
            /*
            //Printing values using Array
            int[] Values = {5,6,9,10,55,20,2,7 };
            //select * from d where d>10 and d<50
            var result = from d in Values  //d is table name
                         where d>10 && d<50
                         select d;
            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
            */
            //For method for printing Values
            /*for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] > 10)
                {
                    Console.WriteLine(i.ToString());
                }
            }*/
            //Student.ShowStudentsDetails(); --to run LinqDemo.cs
            //HandOnLinq1 handsOnLinq1 = new HandOnLinq1();
            //--> calling handOn Que 1. 
            //handsOnLinq1.PositiveNo();

            //--> calling handOn Que 2.
            //handsOnLinq1.FrequencyOfNo();

            //--> calling handOn Que 3.
            // handsOnLinq1.DisplayAndFreq();

            //--> calling handOn Que 4.
            //handsOnLinq1.StartsAndEnds();

            //--> calling handOn Que 5.
            //handsOnLinq1.TopNrecord();

            //-->calling handOn Que 6
            // Students.NthMaxGrade();

            //-> calling handOn Que 7 and 8
            //Person.LastNameWithD();

            //-> calling handOn Que 10
            //handsOnLinq1.WordStartsWithL();

            //-> calling handOn Que 11
            //handsOnLinq1.MultipleOf4and6();
            Person.LastNameWithD();
            Console.ReadLine();
        }
    }
}
