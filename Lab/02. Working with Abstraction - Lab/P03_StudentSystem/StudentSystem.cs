using System;
using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> students;

    public StudentSystem()
    {
        this.students = new Dictionary<string, Student>();
    }

    public void ParseCommand(string input)
    {
        var inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var command = inputParts[0];

        switch (command)
        {
            case "Create":
                this.CreateCommand(inputParts);
                break;
            case "Show":
                this.ShowCommand(inputParts);
                break;
        }
    }

    private void ShowCommand(string[] inputParts)
    {
        var name = inputParts[1];

        if (this.students.ContainsKey(name))
        {
            var student = this.students[name];
            Console.WriteLine(student);
        }
    }

    private void CreateCommand(string[] inputParts)
    {
        var name = inputParts[1];
        var age = int.Parse(inputParts[2]);
        var grade = double.Parse(inputParts[3]);

        if (!this.students.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            this.students[name] = student;
        }
    }
}