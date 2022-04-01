namespace generalNamespace;

public class Timer {

    public float TIME_STEP = (float) (1.0 / 60.0);
    private float lag;
    private DateTime previous;
    private float frames;
    private float seconds;
    private float updates;
    
    public Timer() {
        this.lag = 0;
        this.previous = DateTime.Now;
        this.frames = 0;
        this.seconds = 0;
        this.updates = 0;
    }

    public void RealTime() {
        this.lag -= this.TIME_STEP;
        this.updates += 1;
    }

    public void Count() {
        DateTime current = DateTime.Now;
        TimeSpan elapsed = current - this.previous;
        this.previous = current;
        this.lag += (float) elapsed.TotalSeconds;
        this.frames += 1;
    }

    public bool CheckLagging() {
        return this.lag >= this.TIME_STEP;
    }
}