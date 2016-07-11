using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_CKawakami300821245_A5
{
    public class Student
    {

      
        public string LastName { get; set;}
        public string FirstName { get; set; }
        public string StudentId { get; set; }
        public string ClassName { get; set; }
        public string Grade { get; set; }

        public Student()
        {

        }
public Student(string lname, string fname,string id,string classname,string grade)
        {
            this.LastName = lname;
            this.FirstName = fname;
            this.StudentId = id;
            this.ClassName = classname;
            this.Grade = grade;

        }
    }
}
