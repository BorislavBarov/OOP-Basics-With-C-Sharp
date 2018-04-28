using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = line[0];
            var salary = decimal.Parse(line[1]);
            var position = line[2];
            var department = line[3];
            var email = string.Empty;
            var age = 0;

            var employee = new Employee(name, salary, position, department);

            if (line.Length == 6)
            {
                email = line[4];
                age = int.Parse(line[5]);

                employee.Email = email;
                employee.Age = age;
            }
            else if (line.Length == 5)
            {
                if (line[4].Contains("@"))
                {
                    email = line[4];
                    employee.Email = email;
                }
                else
                {
                    age = int.Parse(line[4]);
                    employee.Age = age;
                }
            }

            employees.Add(employee);
        }

        var result = employees
            .GroupBy(x => x.Department)
            .Select(x => new
            {
                DepartmentName = x.Key,
                AverageSalary = x.Average(y => y.Salary),
                Employees = x.OrderByDescending(y => y.Salary)
            })
            .OrderByDescending(x => x.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.DepartmentName}");

        foreach (var employee in result.Employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}