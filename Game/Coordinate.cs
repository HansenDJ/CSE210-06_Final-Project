namespace generalNamespace;

public class Coordinate
{
    public bool finalFrame;
    public int frame;
    public int x = 0;
    public int y = 0;

    public void IncrementFrame()
    {
        frame++;
        if (frame >= ImageService.explosionFrameLength) finalFrame = true;
    }
}