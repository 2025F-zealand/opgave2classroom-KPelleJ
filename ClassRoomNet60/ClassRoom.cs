using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public DateTime StartOfSemester { get; set; }

        public ClassRoom() 
        { 
            Students = new List<Student>();
        }

        public void SeasonalCounter()
        { 
            int Winter = 0;
            int Spring = 0;
            int Summer = 0;
            int Fall = 0;

            foreach (Student student in Students)
            {
                switch (student.MonthOfBirth)
                {
                    case 1:
                    case 2:
                    case 12:
                        Winter++;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Spring++;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Summer++;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Fall++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Count of students per season:");
            Console.WriteLine($"Winter = {Winter} students");
            Console.WriteLine($"Spring = {Spring} students");
            Console.WriteLine($"Summer = {Summer} students");
            Console.WriteLine($"Fall = {Fall} students");
        }
        
        public void SeasonalCounterLinq()
        {
            var WinterStudents = Students.Where(x => x.MonthOfBirth == 12 || x.MonthOfBirth == 1 || x.MonthOfBirth == 2);
            var SpringStudents = Students.Where(x => x.MonthOfBirth == 3 || x.MonthOfBirth == 4 || x.MonthOfBirth == 5);
            var SummerStudents = Students.Where(x => x.MonthOfBirth == 6 || x.MonthOfBirth == 7 || x.MonthOfBirth == 8);
            var FallStudents = Students.Where(x => x.MonthOfBirth == 9 || x.MonthOfBirth == 10 || x.MonthOfBirth == 11);

            Console.WriteLine("Students divided by Month of Birth");
            Console.WriteLine($"Winter students: {WinterStudents.Count()}");
            Console.WriteLine($"Spring students: {SpringStudents.Count()}");
            Console.WriteLine($"Summer students: {SummerStudents.Count()}");
            Console.WriteLine($"Fall students: {FallStudents.Count()}");
        }
    }
}
