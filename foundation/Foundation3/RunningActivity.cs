using System.Diagnostics.Contracts;

public class RunningActivity : Activity {

    public RunningActivity(double distance, double time) : base(distance, time)
    {
        _type = "Running";
    }

    public string GetActivityType()
    {
        return _type;
    }

    public override void CalculateDistance()
    {

    }

    public override void CalculateSpeed()
    {
       _speed = _distance / _time * 60; 
    }

    public override void CalculatePace()
    {
        _pace = _time / _distance;
    }
}