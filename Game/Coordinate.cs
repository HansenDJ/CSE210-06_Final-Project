namespace generalNamespace;

public class Coordinate
{
    public int x = 0;
    public int y = 0;
    public int frame = 0;
    public bool finalFrame = false;

    public void IncrementFrame()
    {
        frame++;
        if(frame >= ImageService.explosionFrameLength)
        {
            finalFrame = true;
        }
    }
}