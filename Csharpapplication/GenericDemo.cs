using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

namespace Csharpapplication
{
    internal class GenericDemo
    {
        public static void Generic()
        {
            Dictionary<int, string> student = new Dictionary<int, string>();
            student[101] = "Passed";
            student[102] = "Passed";
            student[103] = "Failed";
            student[104] = "Passed";

            foreach (var item in student)
            {
                student[item.Key] = item.Value;
            }
        }
        public static void Data()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);

            int value = Convert.ToInt32(arrayList[0]);

            //Generic
            List<int> list = new List<int>();
            list.Add(10);

            int myValue = list[0];

            //Stack- LIFO
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("Raj");
            stack.Push(5000);

            Console.WriteLine("stack");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("******");

            //Queue- FIFO
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("Raj");

            queue.Dequeue();


        }
    }
}
