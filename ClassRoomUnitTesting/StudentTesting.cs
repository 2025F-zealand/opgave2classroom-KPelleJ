using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomUnitTesting
{
    public class StudentTesting
    {
        public void Setup()
        {
            Student teststudent1 = new Student("per", 1, 1);
        }

        [TestCase("Peter",1,2)]
        public void Create_Student_Control_Values(string name, int month, int day)
        {
            //Assign
            Student testStudent = new Student(name, month, day);

            //Act


            //Assert
            Assert.That(testStudent.Name.Equals(name));
            Assert.That(testStudent.Birthday.Equals(day));
            Assert.That(testStudent.MonthOfBirth.Equals(month));
        }

        [TestCase("per", 1, 1)]
        [TestCase("per", 2, 1)]
        [TestCase("per", 3, 1)]
        [TestCase("per", 4, 1)]
        [TestCase("per", 5, 1)]
        [TestCase("per", 6, 1)]
        [TestCase("per", 7, 1)]
        [TestCase("per", 8, 1)]
        [TestCase("per", 9, 1)]
        [TestCase("per", 10, 1)]
        [TestCase("per", 11, 1)]
        [TestCase("per", 13, 1)]
        public void Student_Season_Assign_Should_Pass(string name, int month, int day)
        { 
            //Assign
            Student testStudent = new Student(name,month,day);

            //Act
            string result = testStudent.Season();

            //Assert
            if (month == 12 || month == 1 || month == 2)
            {
                Assert.That(result.Equals("Winter Doomer"));
            }

            if (month == 3 || month == 4 || month == 5)
            {
                Assert.That(result.Equals("Spring Child"));
            }

            if (month == 6 || month == 7 || month == 8)
            {
                Assert.That(result.Equals("Summer Baby"));
            }

            if (month == 9 || month == 10 || month == 11)
            {
                Assert.That(result.Equals("Fall Person"));
            }
        }
    }
}
