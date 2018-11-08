using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Students
    {
        // Attributes that are made private can only be accessed in this Students class and no where else.
        private string StudentNumber;
        private string StudentName;
       

        private Students()// This is the default constructor. Due to it being private you can not create an instance of Students. eg Students students= new Students(); will not work
        {

        }
        public Students(string studentnumber,string studentname)// This is the Parameterized constructor and because it is public we can access it outside the Students class. eg Students students= new Students("21612345","Todd");// this constructor takes three parameters.
        {
            StudentNumber = studentnumber;
            StudentName = studentname;
          
        }
        public string Student_Number
        {
            get {return StudentNumber; }
        }
        public string Student_Name
        {
            get { return StudentName; }
        }
       

        public string PassType(double average) // Simple Method which can be accessed outside the class. It also takes one parameter.
        {
            string Start = StudentName + "(" + StudentNumber + ")";
            if (average>=75 && average<=100)
            {
                return Start+":Distinction";
            }
            else if(average >=50 && average <75)
            {
                return Start + ":Pass";
            }
            else if(average>=0 && average <50)
            {
                return Start + ":Fail";
            }
            else
            {
                return Start + ":Inccorect Average";
            }
        }
    }
}
