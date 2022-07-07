using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpapplication
{
    internal class ArrayDemo
    {
        public static void GetTotalTickets()    //STATIC means we cannot access this function
        {
            string [] data= {"A","B"};
            // Whatis JAGGED ARRAY? Easy to customise
            string[][] counter= new string [3][];
            counter[0] = new string[3];                       //counter[0] = [ "A","B"];
            counter[1] = new string[2];
            counter[2] = new string[4];

            counter[0][0] ="p1";
            counter[0][1]= "p2";
            counter[0][2] ="p3";

            counter[1][0] = "p4";
            counter[1][1] = "p5";

            counter[2][0] = "p6";
            counter[2][1] = "p7";
            counter[2][2] = "p8";
            counter[2][3] = "p9";
            counter[2][4] = "p10";

            int i = 0;


        }
    }
}
