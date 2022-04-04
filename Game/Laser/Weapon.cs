namespace generalNamespace.Laser;

public class Weapon : Character

{
    public static int reloadTime = 0;
    public int laserID;
    public int randomBossWeaponY = 0;
    public bool location = false;
    public int powerUpShot = 0;
    public int speed = 25;
    public int strength = 5;
    public int direction = 0;


    public void SetStrength(int s)
    {
        strength = s;
    }

   

    public void MoveWeaponLeft()
    {
        x -= speed;
    }

    public void MoveWeaponRight()
    {
        x += speed;
    }

    public void ChooseWeaponDirectionandMove()
    {
        switch (direction)
        {
            case 0:
                MoveWeaponLeft();
                break;
            case 1: MoveWeaponRight();
                break;
            case 2: MoveWeaponUp();
                break;
            case 3: MoveWeaponDown();
                break;
        }
    }
    public void MoveWeaponUp()
    {
        y -= speed;
    }

    public void MoveWeaponDown()
    {
        y += speed;
    }
}