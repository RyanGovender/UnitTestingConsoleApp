using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentTypePassWithDistinction()
        {
            //Arrange 
            Students students = new Students("21612345","Todd"); // We called the Parameterized constructor as the default constructor is private.
            double average = 78;// The parameter for PassType
            string expected =students.Student_Name+"("+students.Student_Number+")"+ ":Distinction";//we are calling the get methods(Student_Number,Student_Name) to get the Name and Student Number we put in the Parameterized constructor. This is what we expect to be returned from the PassType method 
            //Actual
            string actual = students.PassType(average); // getting the actual outcome of running the PassType Method
            //Assert
            Assert.AreEqual(expected,actual);// check if the expect and actual are equal.
        }
        //Student Name:Bill
        //Student Number:2161433
        //Why is this test failing? Check the code and correct the error.
        [TestMethod]
        public void StudentTypePass()
        {
            //Arrange 
            Students students = new Students("2161433","Bill"); // We called the Parameterized constructor as the default constructor is private.
            double average = 49;// The parameter for PassType
            string expected = students.Student_Name + "(" + students.Student_Number + ")" + ":Pass";//we are calling the get methods(Student_Number,Student_Name) to get the Name and Student Number we put in the Parameterized constructor. This is what we expect to be returned from the PassType method 
            //Actual
            string actual = students.PassType(average); // getting the actual outcome of running the PassType Method
            //Assert
            Assert.AreEqual(expected, actual);// check if the expect and actual are equal.
        

    }
        //StudentName: Frank
        //StudentNumber:21412345
        //Student Average:45
        [TestMethod]
        public void StudentTypeFail()
        {
            //Arrage 



            //Actual

            //Assert

        }
        //StudentName: Anne
        //StudentNumber:21412345
        //Student Average:102
        [TestMethod]
        public void StudentTypeIncorrectAverageGreaterThan100()
        {
            //Arrage 



            //Actual

            //Assert

        }
        // Do a unit test for Anne but this time her average is negative 10(-10). Change the method name and complete the three As.
        [TestMethod]
        public void ChangeName()
        {
            //Arrage 



            //Actual

            //Assert

        }

    }
}
