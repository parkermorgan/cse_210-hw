public class SwimmingActivity : Activity {

    private double _laps;
    public SwimmingActivity(double laps, double time) : base(0, time)
    {
        _type = "Swimming";
        _laps = laps;
        CalculateDistance();
        CalculatePace();
        CalculateSpeed();
    }

    public override void CalculateSpeed()
    {
        _speed = _distance / _time * 60;
    }

    public override void CalculatePace()
    {
        _pace = _time / _distance;
    }

    public override void CalculateDistance()
    {
         _distance = _laps * 50 / 1000 * 0.62;
    }
}