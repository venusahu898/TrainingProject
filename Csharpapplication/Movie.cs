using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //File Handling: for file handling import "System.IO"

namespace Csharpapplication
{
    internal class Movie
    {
        public void CreateMovie(int MovieId, String MovieName, String MovieDesc, String MovieLanguage)
        {
            //Step 1: How to create file?
            FileStream fileStreamObj = new FileStream(@"C:\Users\VENSAHU\Documents\Visual Studio 2022\Code Snippets\ConsoleApp.NET Framework\movie.text", FileMode.Create, FileAccess.Write);
            // Step 2: How to write File?
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            streamWriter.WriteLine("Enter movieId: " + MovieId + "\nEnter movieName: " + MovieName+ 
                              "\nEnter movieDesc: " + MovieDesc + "\nEnter movieLanguage: " + MovieLanguage);
            
            
            streamWriter.Close();// Close Writing operation
            fileStreamObj.Close();// Close file operation
            Console.WriteLine(" show :", MovieId, MovieName, MovieDesc , MovieLanguage);
        }

        //Reading data from File to Console
        public void SelectMovies()
        {
            FileStream fileStream= new FileStream(@"C:\Users\VENSAHU\Documents\Visual Studio 2022\Code Snippets\ConsoleApp.NET Framework\movie.text",FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            /*streamReaderObj.ReadLine(); //will read 2nd line and point to 3rd line
            streamReaderObj.ReadLine(); //will read 3rd line and point to 4th line */

            /*Console.WriteLine(streamReaderObj.ReadLine());
            Console.WriteLine(streamReaderObj.ReadLine());
            Console.WriteLine(streamReaderObj.ReadLine());
            Console.WriteLine(streamReaderObj.ReadLine()); */

            // Reading lines using while loop
            while (streamReaderObj.Peek() > 0)
            {
                //  Console.WriteLine(streamReaderObj.ReadLine());

                //fileStream.Close(); */

                //HOW TO DECLARE ARRAY
                //FIXED ARRAY AND DYNAMIC ARRAY
                string[] myValues = new string[5]; //Fixed array
                myValues[0] = "a";
                myValues[1] = "b";
                myValues[2] = "c";
                myValues[3] = "d";
                myValues[4] = "e";
                while (streamReaderObj.Peek() > 0)
                {
                    string line = streamReaderObj.ReadLine();
                    string[] myStrs = line.Split(':'); //Dynamic array
                    Console.WriteLine(myStrs[1]);
                }
            }
            fileStream.Close();

        }
    }

}


