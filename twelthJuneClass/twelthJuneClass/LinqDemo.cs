using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOPS, Design pattern
//Async await
//Parallel Programming

//Linq- Language integrated query- select statement
//Linq with objects(collections)
//Linq with XML
// Linq with Dataset/ DataTable

namespace twelthJuneClass
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int TotalMarks { get; set; }
        public string Grade { get; set; }
        public static void ShowStudentsDetails()
        {
            List<Student> studentList = new List<Student>()
                {
                //List of Students Object
                   new Student{Id=111, Name= "Raj", Department= "IT", TotalMarks= 80, Grade="A"},
            //this is short form for object declaration.
            //INSTEAD of writing commented down lines.
                   new Student{Id = 112, Name = "Mahi", Department = "EEE", TotalMarks = 70, Grade = "B" },
                   new Student{Id=113, Name= "Vasu", Department= "ECE", TotalMarks= 90, Grade="A+"},
                   new Student{Id=114, Name= "Gani", Department= "CSE", TotalMarks= 60, Grade="C"},
                   new Student{Id=115, Name= "Rahul", Department= "IT", TotalMarks= 70, Grade="B"},
                   new Student{Id=116, Name= "Ved", Department= "EEE", TotalMarks= 90, Grade="A+"},
                   new Student{Id=117, Name= "Ram", Department= "ECE", TotalMarks= 30, Grade="F"},
                };

            var result = from studentData in studentList
                         where studentData.Grade == "C"
                         orderby studentData.TotalMarks ascending
                         select studentData; //will select all
                                             //to filter particular column name 
            /*select new Student()
            {
                Id = studentData.Id,
                Name = studentData.Name,

            };*/
            //To filter Top 3 students * from table where marks>85
            var result1 = (from studentData in studentList
                           where studentData.TotalMarks > 85
                           orderby studentData.TotalMarks descending
                           select new Student()
                           {
                               Id = studentData.Id,
                               Name = studentData.Name,

                           }).Take(3).ToList(); //.ToList()- with this query will be executed, without foreach

            foreach (var item in result1)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Department);
                Console.WriteLine(item.TotalMarks);
                Console.WriteLine(item.Grade);
            }
            /*Student studentObj = new Student(); //M101 
       studentObj.Id = 111;
       studentObj.Name = "Raj";
       studentObj.Department = "IT";
       studentObj.TotalMarks = 80;
       studentObj.Grade = "A";

       studentList.Add(studentObj);

       studentObj = new Student(); //M102- everytime we have to create an object to enter data 
       studentObj.Id = 112;        //If we don't, the below objects data will override previous one.
       studentObj.Name = "Mahi";
       studentObj.Department = "EEE";
       studentObj.TotalMarks = 75;
       studentObj.Grade = "B";

       studentList.Add(studentObj);*/

        }

    }
    internal class LinqDemo
    {
       
    }

}

