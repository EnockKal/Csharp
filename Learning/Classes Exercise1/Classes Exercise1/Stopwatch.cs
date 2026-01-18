namespace Classes_Exercise1;

public class Stopwatch
{
    private DateTime _startTime;
    private DateTime _stopTime;
    private bool _isRunning;

    public void Start()
    {
        if (_isRunning)
            throw new InvalidOperationException("Can't start twice");

        _isRunning = true;
        _startTime = DateTime.Now;
    }


    public void Stop()
    {
        if (!_isRunning)
            throw new InvalidOperationException("Need to start first");

        _isRunning = false;
        _stopTime = DateTime.Now;
    }

    public TimeSpan getDuration()
    {

        return _stopTime - _startTime;
    }

}
