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
 * Date Modified : 18th July 2016
 * Description: This program create text file and display it 
 * version 0.0.5 - updated Main method to change the way to create text file which includes students data
 */
namespace COMP123_S2016_CKawakami300821245_A5
{
  /**
   * <summary>
   * The Maim method for our driver class program
   * </summary>
   * @class: program
   */
    class Program
    {
 /**
  * <summary>
  * The Main method for our driver class program
  * </summary>
  * @constructor:Main
  * @param {string[]}args
  */
        static void Main(string[] args)
        {

            string FILENAME = "../../grade.txt";
           

            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            string[] fName = { "Owen", "John", "Davis" };
            string[] lName =  {"Carter","Fox","Lorenzo"};
            string[] idNumber = { "AB123", "BC223", "MO345" };
            string[] className = { "Programming2", "ComputerScience", "JAVA" };
            string[] grade = { "A+", "B+", "C" };
            for (int i = 0; i < 3; i++)
            {
                Student student = new Student(lName[i], fName[i], idNumber[i], className[i], grade[i]);

                writer.WriteLine(student);
                
                
            }
          
            /*
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
             * */
       
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
                    Console.WriteLine("FILE Does Exist!");
              
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
                Console.WriteLine("No such File");
                Console.WriteLine(error.Message);
            }

        }//end program 

 /**
  * <summary>
  * The Method is to read grade.txt file 
  * </summary>
  * @Method: DisplayMethod
  * @return:{void}
  * 
  */
    
           public static void DisplayMethod()
            {
                const char DELIM = ',';
                string FILENAME = "../../grade.txt";

                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);
               Student student = new Student();
                string readerString = reader.ReadLine();
                string[] fields;
                Console.WriteLine("\n{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}\n","LastName","FirstName","#ID","Class","Grade");
                            while (readerString != null)
                            {
                                fields = readerString.Split(DELIM);
                                student.LastName = fields[0];
                                student.FirstName = fields[1];
                                student.StudentId = fields[2];
                                student.ClassName = fields[3];
                                student.Grade = fields[4];
                                Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}",
                                    student.LastName,
                                    student.FirstName,
                                    student.StudentId,
                                    student.ClassName,
                                    student.Grade);
                                readerString = reader.ReadLine();
                            }
                            reader.Close();
                            inFile.Close();
           }//end DisplayMethod()
        }//program
    }//class 
/*
 Student student1 = new Student("Carter","Owen","A123","Programming2","A+");
            Student student2 = new Student("Fox", "John", "B234", "ComputerScience", "B+");
            Student student3 = new Student("Lorenzo", "Davis", "C567", "JAVA", "C+");
            writer.Write(student1);
            writer.WriteLine(student2);
            writer.WriteLine(student3);
*/