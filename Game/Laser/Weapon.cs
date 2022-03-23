namespace generalNamespace.Laser;

public class Weapon : Character

{
    public Character owner;
    public int speed = 5;
    public bool location = false;

    public void setOwner(Character c)
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