using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_CKawakami300821245_A5
{
    /**
     * This class defines a generic Student
     * 
     * @class Student
     * @param 
     * 
     */
    public class Student
    {

        //PUBLIC INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a propety for our LastName field
         * </summary>
         * @property{string} LastName
         */
        public string LastName { get; set;}
        /**
      * <summary>
      * This is a propety for our FirstName field
      * </summary>
      * @property{string} FirstName
      */
        public string FirstName { get; set; }
        /**
      * <summary>
      * This is a propety for our StudentId field
      * </summary>
      * @property{string} StudentId
      */
        public string StudentId { get; set; }
        /**
      * <summary>
      * This is a propety for our ClassName field
      * </summary>
      * @property{string} ClassName
      */
        public string ClassName { get; set; }
        /**
      * <summary>
      * This is a propety for our Grade field
      * </summary>
      * @property{string} Grade
      */
        public string Grade { get; set; }


        //CONSTRUCTOR****************************************************************************
        /**
         * <summary>
         * This is the empty default Constructor for Student class to read grade.txt
         * 
         * </summary>
         * @constructor Student
         * 
         */

        public Student()
        {

        }


        //CONSTRUCTOR****************************************************************************
        /**
         * <summary>
         * This is the Constructor for the Student class
         * </summary>
         * @constructor Student
         * @params {string}name,{string}fname,{string}id,{string}classname,{string}grade
         * 
         */
public Student(string lname, string fname,string id,string classname,string grade)
        {
            this.LastName = lname;
            this.FirstName = fname;
            this.StudentId = id;
            this.ClassName = classname;
            this.Grade = grade;

        }
/**
* <summary>
* This is ToString Method to console LastName, FirstName,StudentId,ClassName,and Grade
* </summary>
* @Method: ToString
* @param:{string}
* @returns {string}
*/
public override string ToString()
{

    return String.Format(this.LastName + "," + this.FirstName + "," + this.StudentId + "," + this.ClassName + "," + this.Grade);
}
    }
}
