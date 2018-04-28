using System;

public class StartUp
{
    public static void Main()
    {
        var firstInputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var firstStudentName = firstInputLine[0];
        var lastStudentName = firstInputLine[1];
        var facultyNumber = firstInputLine[2];

        var secondInputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var firstWorkerName = secondInputLine[0];
        var lastWorkerName = secondInputLine[1];
        var weekSalary = decimal.Parse(secondInputLine[2]);
        var hoursPerDay = decimal.Parse(secondInputLine[3]);

        try
        {
            var student = new Student(firstStudentName, lastStudentName, facultyNumber);
            var worker = new Worker(firstWorkerName, lastWorkerName, weekSalary, hoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}