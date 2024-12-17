using System.Runtime;
using System.Security.AccessControl;

public abstract class Activity {
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected double _time;
    protected string _date;
    protected string _type;

    
    public Activity (double distance, double time)
    {
        _distance = distance;
        _time = time;
        CalculateSpeed();
        CalculatePace();
        CalculateDistance();
        GetDate();
    }

    public void GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public abstract void CalculateSpeed();
    public abstract void CalculatePace();
    public abstract void CalculateDistance();

    public void GetSummary()
    {
        string formattedDate = DateTime.Parse(_date).ToString("dd MMM yyyy");

        Console.WriteLine($"{formattedDate} {_type}: ({_time} min)- Distance {_distance:F1} miles, Speed {_speed:F1} mph, Pace: {_pace:F1} min per mile.");
    }
}