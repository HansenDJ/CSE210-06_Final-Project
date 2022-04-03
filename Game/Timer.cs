namespace generalNamespace;

public class Timer
{
    private float frames;
    private float lag;
    private DateTime previous;
    private float seconds;

    public float TIME_STEP = (float) (1.0 / 60.0);
    private float updates;

    public Timer()
    {
        lag = 0;
        previous = DateTime.Now;
        frames = 0;
        seconds = 0;
        updates = 0;
    }

    public void previousReset()
    {
        this.previous = DateTime.Now;
    }


    public void RealTime()
    {
        lag -= TIME_STEP;
        updates += 1;
    }

    public void Count()
    {
        var current = DateTime.Now;
        var elapsed = current - previous;
        previous = current;
        lag += (float) elapsed.TotalSeconds;
        frames += 1;
    }

    public bool CheckLagging()
    {
        return lag >= TIME_STEP;
    }
}