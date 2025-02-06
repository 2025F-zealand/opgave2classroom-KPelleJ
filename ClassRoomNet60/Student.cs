using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int MonthOfBirth { get; private set; }
        public int Birthday { get; private set; }

        public Student(string name, int monthOfBirth, int birthDay) 
        { 
            Name = name;
            MonthOfBirth = monthOfBirth;
            Birthday = birthDay;
        }
    }
}
