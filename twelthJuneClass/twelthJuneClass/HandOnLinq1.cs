using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twelthJuneClass
{
    internal class HandOnLinq1
    {
        //1.Write a program in C# Sharp to find the positive numbers from a list of numbers
        //using two where conditions in LINQ Query.
        public void PositiveNo()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = from d in n1
                         where d > 0
                         orderby d ascending
                         select d;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //2.Write a program in C# Sharp to display the number and frequency of number from given array.
        public void FrequencyOfNo()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var result = from d in arr1
                         group d by d into y
                         select y;
            foreach (var arrCount in result)
            {

                Console.WriteLine("Number {0} appears {1} times", arrCount.Key, arrCount.Count());
            }

        }
        //3.Write a program in C# Sharp to display the characters and
        //frequency of character from giving string
        public void DisplayAndFreq()
        {
            string nString = "apple";
            var result = from d in nString
                         group d by d into y
                         select y;
            foreach (var stringChar in result)
            {
                Console.WriteLine("Character {0}: {1} times", stringChar.Key, stringChar.Count());
            }
        }

        //4. Write a program in C# Sharp to find the string which starts and ends with a specific character
        public void StartsAndEnds()
        {
            Console.WriteLine("The cities are : ");
            string[] cityList = {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                                  "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //Input starting character for the string : A
            //Input ending character for the string : M

            var result = from d in cityList
                         where d.StartsWith("A") && d.EndsWith("M")
                         select d;
            foreach (var stringC in result)
            {
                Console.WriteLine("The city starting with A and ending with M is : {0} ", stringC);
            }

        }
        //5. Write a program in C# Sharp to display the top n-th records.

        public void TopNrecord()
        {
            Console.WriteLine("The members of the list are :");
            int[] arrList = { 5, 7, 13, 24, 6, 9, 8, 7 };
            Console.Write("How many records you want to display ? :");
            int n = Convert.ToInt32(Console.ReadLine());

            var result = (from d in arrList
                          orderby d descending
                          select d).Take(n).ToArray();
            foreach (var topRecord in result)
            {
                Console.WriteLine("The top 3 records from the list are :" + topRecord);
            }

        }
       // 10. Find the words in the collection that start with the letter 'L
    public void WordStartsWithL()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", 
                                                       "Orange", "Lime", "Watermelon", "Loganberry" };
            var result = from f in fruits
                         where f.StartsWith("L")
                         select f;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        //11.	Which of the following numbers are multiples of 4 or 6
        public void MultipleOf4and6()
        {
            List<int> mixedNumbers = new List<int>()
            { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };
            var result = from d in mixedNumbers
                         where d % 4 == 0 || d % 6 == 0
                         select d;
            Console.Write("All the numbers which are multiple of 4 or 6 area : ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }

    }
    //6. Write a program in C# Sharp to find the n-th Maximum grade point
    //achieved by the student from the list of students.
    public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public static void NthMaxGrade()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            Console.Write("How many records you want to display ? :");
            int n = Convert.ToInt32(Console.ReadLine());

            var result = (from d in stulist
                          orderby d.GrPoint descending
                          select new Students()
                          {
                              StuId = d.StuId,
                              StuName = d.StuName,
                              GrPoint = d.GrPoint,

                          }).Take(n).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.StuId);
                Console.WriteLine(item.StuName);
                Console.WriteLine(item.GrPoint);
            }
        }
    }
    //7. linq statement for people with last name that starts with the letter D
    public class Person
    {  
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public static void LastNameWithD()
        {
            List<Person> people = new List<Person>()
                {
                    new Person{Fname="Bill", Lname= "Smith",Age= 41 },
                    new Person{Fname="Sarah", Lname= "Jones",Age= 22},
                    new Person{Fname="Stacy",Lname="Baker", Age= 21 },
                    new Person{Fname="Vivianne",Lname="Dexter",Age= 19 },
                    new Person{Fname = "Bob", Lname = "Smith", Age = 49},
                    new Person { Fname = "Brett", Lname = "Baker", Age = 51 },
                    new Person { Fname = "Mark", Lname = "Parker", Age = 19 },
                    new Person { Fname = "Alice", Lname = "Thompson", Age = 18 },
                    new Person { Fname = "Evelyn", Lname = "Thompson", Age = 58 },
                    new Person { Fname = "Mort", Lname = "Martin", Age = 58 },
                    new Person { Fname = "Eugene", Lname = "DeLauter", Age = 84 },
                    new Person { Fname = "Gail", Lname = "Dawson", Age = 19 },
                };
            //var result = from d in people
            //             where d.Lname.StartsWith("D")
            //             select d;
            //foreach (var person in result)
            //{
            //    Console.WriteLine(person.Lname);
            //}
            ////8. Number of people whose last name starts with the letter D.

            //var result8 = from d in people
            //              where d.Lname.StartsWith("D")
            //              group d by d.Lname into y
            //              select y;
            //foreach (var personD in result8)
            //{
            //    Console.WriteLine(personD.Count());
            //}

            //9. Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name
      
            var result9 = from d in people
                          where d.Age> 40
                          orderby d.Fname descending
                          select d;
            foreach (var personD in result9)
            {
                Console.WriteLine(personD.Fname);
            }
        }
    }

}
