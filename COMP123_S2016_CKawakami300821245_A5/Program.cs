using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
 * This is driver class
 * Author: Chinatsu Kawakami
 * StudentID:300821245
 * Date: 7th July 2016
 * Date Modified : 11th July 2016
 * Description:  
 * version 0.0.2 - create grade.txt file
 */
namespace COMP123_S2016_CKawakami300821245_A5
{
  /**
   * The Maim method for our driver class program
   * @class: program
   */
    class Program
    {
 /**
  * The Main method for our driver class program
  * 
  * @constructor:Main
  * @param {string[]}args
  */
        static void Main(string[] args)
        {
            
            string FILENAME = "../../grade.txt";
            const char DELIM = ',';
          
            FileStream outFile = new FileStream(FILENAME,FileMode.Create,FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            student student = new student();
   
            Console.WriteLine("Enter LASTNAME of student or end to quit");

            student.LastName = Console.ReadLine();

            while(student.LastName != "end")
            {
                Console.WriteLine("Enter FirstName");
                student.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Student ID");
                student.StudentId = Console.ReadLine();
                Console.WriteLine("Enter Class Name");
                student.ClassName = Console.ReadLine();
                Console.WriteLine("Enter Grade");
                student.Grade = Console.ReadLine();
                writer.WriteLine(student.LastName + DELIM + student.FirstName + DELIM + student.StudentId + DELIM + student.ClassName + DELIM + student.Grade); 
                Console.WriteLine("Enter LASTNAME of student or end to quit");
                student.LastName = Console.ReadLine();
                
            }
            writer.Close();
            outFile.Close();
               
           


           /* student.LastName = "Carter";
            student.FirstName = "Owen";
            student.StudentId = "A123";
            student.ClassName = "Programming2";
            student.Grade = "A+";

            student.LastName = "Fox";
            student.FirstName = "John";
            student.StudentId = "B234";
            student.ClassName = "ComputerScience";
            student.Grade = "B";

            student.LastName = "Lorenzo";
            student.FirstName = "Davis";
            student.StudentId = "C567";
            student.ClassName = "JAVA";
            student.Grade = "C+";
            writer.WriteLine(student.LastName + DELIM + student.FirstName + DELIM + student.StudentId + DELIM + student.ClassName + DELIM + student.Grade); 
*/


            
          
        }
    }
}
