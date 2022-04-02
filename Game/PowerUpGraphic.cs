namespace generalNamespace;

public class PowerUpGraphic
{
    public int  x = 0;
    public  int y = 0;
    public int ID = 0;
    public int fallSpeed = 5;

    public void Fall()
    {
        y += fallSpeed;
        x -= 4;
    }
    

    public void SetFallSpeed()
    {
        Random rnd = new Random();
        fallSpeed = rnd.Next(1,5);
    }
    

}