using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment();
        Console.WriteLine(assignment1.GetSummary("Samuel Bennett", "Multiplication"));
        Console.WriteLine(assignment1.GetHomeworkList("7.3", "8-19"));
    }
}