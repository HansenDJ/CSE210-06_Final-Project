namespace generalNamespace;

public class PowerUpGraphic : Character
{
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