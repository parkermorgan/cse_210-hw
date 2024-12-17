public class CyclingActivity : Activity {
    public CyclingActivity(double speed, double time) :base(0, time)
    {
        _type = "Cycling";
        _speed = speed;
        CalculateDistance();
        CalculatePace();
    }

    public override void CalculateSpeed()
    {
    }

    public override void CalculatePace()
    {
        _pace = 60 / _speed;
    }

    public override void CalculateDistance()
    {
        double _hourTime = _time / 60;
        _distance = _speed * _hourTime;
    }
}