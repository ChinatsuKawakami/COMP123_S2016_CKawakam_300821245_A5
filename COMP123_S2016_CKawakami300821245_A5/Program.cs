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
 * Description: This program create text file and display it 
 * version 0.0.3 - create method to display textfile
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

            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Student student = new Student();

            Console.WriteLine("Enter LASTNAME of student or end to quit");

            student.LastName = Console.ReadLine();

            while (student.LastName != "end")
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




            try
            {
                Console.WriteLine("**************************");
                Console.WriteLine("*Enter 1 : Display Grades*");
                Console.WriteLine("*Enter 2 : Exit          *");
                Console.WriteLine("**************************");
                Boolean cont = true;
                if(File.Exists(FILENAME))
                {
                    Console.WriteLine("FILE exists");
              
                while (cont)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.WriteLine("* Student Grades Information ************");
                            DisplayMethod();
                            break;//while 
                        case ConsoleKey.D2:
                            cont = false;
                            break;

                    }//switch end 
                }// while end
            }
            }//try
            catch (Exception error)
            {
                Console.WriteLine("File no exists!");
                Console.WriteLine(error.Message);
            }

        }//end program 
    
           public static void DisplayMethod()
            {
                const char DELIM = ',';
                string FILENAME = "../../grade.txt";

                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);
               Student student = new Student();
                string readerString = reader.ReadLine();
                string[] fields;
                Console.WriteLine("\n{0,-5}{1,-12}{2,-15}{3,8}{4,10}\n","StudentLastName","StudentFirstName","#ID","Class","Grade");
                            while (readerString != null)
                            {
                                fields = readerString.Split(DELIM);
                                student.LastName = fields[0];
                                student.FirstName = fields[1];
                                student.StudentId = fields[2];
                                student.ClassName = fields[3];
                                student.Grade = fields[4];
                                Console.WriteLine("{0,-5}{1,-12}{2,-15}{3,8}{4,10}",
                                    student.LastName,
                                    student.FirstName,
                                    student.StudentId,
                                    student.ClassName,
                                    student.Grade);
                                readerString = reader.ReadLine();
                            }
           
           }//end DisplayMethod()
        }//program
    }//class 
