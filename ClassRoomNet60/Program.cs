using ClassRoomNet60;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            ClassRoom c = new ClassRoom();
            c.Name = "3B";
            c.StartOfSemester = new DateTime(2024, 9, 1);
            c.Students.Add(new Student("Nikolaj", 12, 8));
            c.Students.Add(new Student("Dølle", 3, 12));
            c.Students.Add(new Student("Kasper", 8, 4));
            c.Students.Add(new Student("Bobby", 15, 31));

            foreach (var student in c.Students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine($"Birthday: {student.Birthday}/{student.MonthOfBirth}");
                Console.WriteLine($"This person is a {student.Season()}");
            }

            c.SeasonalCounterLinq();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
                

    }
}