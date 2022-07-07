using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Return type methods- int, string, float, decimal, object
// No Return Type Methods - Void 
namespace Csharpapplication
{


    //get set method-properties

    public class Mobile 
    {
        Mobile mobileobject = new Mobile();

        private string IEMTCode { get; set; } //can read and write

        public string SIMCard { get; set; }

        public string processor { get;    } //can only read

        public void Receive() {  }


    }

    public class MI:Mobile
    {
        public void GetIEMTCode()
        {

        }
        
        public void Dial()
        {

        }
    }



    public class Employee
    {
        public int EventId;
        public void Customers()
        {
            int customerId;

        }
        public int CreateEvents() //Return type - should be same as mentioned returned type
        {
            int EventId;
            int EventName;
            int EventDescription;
            int Eventtype;

            Console.WriteLine("Event Created!");
            return 10;
        }
        public void SelectEvents() //Non-Return Type
        {
            Console.WriteLine("Events Selected!");
            

        }
    }
}
