using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

            if (monthOfBirth < 1 || monthOfBirth > 12)
            {
                throw new InvalidDataException($"The birth month is invalid for new student: {this.Name}");
            }

            if (birthDay < 1 || birthDay > 31)
            {
                throw new InvalidDataException($"The birthday is invalid for new student: {this.Name}");
            }
        }

        public string Season()
        {
            switch (this.MonthOfBirth)
            {
                case 1:
                case 2:
                case 12:
                    return "Winter Doomer";
                case 3:
                case 4:
                case 5:
                    return "Spring Child";
                case 6:
                case 7:
                case 8:
                    return "Summer Baby";
                case 9:
                case 10:
                case 11:
                    return "Fall Person";
                default:
                    return "Alien";
            }
        }
    }
}
