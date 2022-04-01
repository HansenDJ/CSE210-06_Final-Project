namespace generalNamespace.Laser;

public class Weapon : Character

{
    public Character owner;
    public int enemyIndex = 0;
    public int speed = 25;
    public bool location = false;
    public int strength = 5;
    public static int reloadTime = 0;
    
    

    public void SetStrength(int s)
    {
        strength = s;
    }
    public void SetOwner(Character c)
    {
        owner = c;
    }
    public void MoveWeaponLeft()
    {
        x -= speed;
    }

    public void MoveWeaponRight()
    {
        x += speed;
    }
    
}