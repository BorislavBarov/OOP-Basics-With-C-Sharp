using System;
using System.Text;

public class Worker : Human
{
    private const int NumberOfWorkingDays = 5;
    private const int MinWeekSalary = 10;
    private const int MinWorkingHours = 1;
    private const int MaxWorkingHours = 12;

    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base (firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        private set
        {
            if (value <= MinWeekSalary)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        private set
        {
            if (value < MinWorkingHours || value > MaxWorkingHours)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal GetSalaryPerHour()
    {
        var result = (this.WeekSalary / NumberOfWorkingDays) / this.WorkHoursPerDay;
        return result;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString())
          .AppendLine($"Week Salary: {this.WeekSalary:f2}")
          .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
          .AppendLine($"Salary per hour: {this.GetSalaryPerHour():f2}");

        return sb.ToString().TrimEnd();
    }
}