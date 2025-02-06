using ClassRoomNet60;

public class Program
{
    private static void Main(string[] args)
    {
        ClassRoom c = new ClassRoom();
        c.Name = "3B";
        c.StartOfSemester = new DateTime(2024, 9, 1);

        try
        {
            c.Students.Add(new Student("Nikolaj", 12, 8));
            c.Students.Add(new Student("Dølle", 3, 12));
            c.Students.Add(new Student("Kasper", 8, 4));
            c.Students.Add(new Student("Bobby", 15, 31));

            Console.WriteLine(c.ToString());
            Console.WriteLine(c.SeasonalCounterLinq());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}