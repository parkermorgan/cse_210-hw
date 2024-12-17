using System;
//PREFACE: ChatGPT was used for resolving errors throughout the program, primarily when calling derived methods.
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity run = new RunningActivity(3.1, 30);
        activities.Add(run);

        SwimmingActivity swim = new SwimmingActivity(40, 30);
        activities.Add(swim);

        CyclingActivity cycling = new CyclingActivity(15, 90);
        activities.Add(cycling);

        foreach(Activity a in activities)
        {
            a.GetSummary();
            Console.WriteLine();
        }
    }
}