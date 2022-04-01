public class Store
{
    public string name = "";
    public int price;

    public void Ability()
    {
    }
    // public bool IsPurchased()
    // {
    //     IsPurchased = false
    // }
}

public class StoreList
{
    public void StoreItemHeart()
    {
        var heart = new Store();
        heart.name = "Heart";
        heart.price = 100;
    }

    public void StoreItemFireRate()
    {
        var FireRate = new Store();
        FireRate.name = "FireRate";
        FireRate.price = 100;
    }

    public void StoreItemMovementSpeed()
    {
        var MovementSpeed = new Store();
        MovementSpeed.name = "MovementSpeed";
        MovementSpeed.price = 100;
    }

    public void StoreItemMissile()
    {
        var Missile = new Store();
        Missile.name = "Missile";
        Missile.price = 100;
    }

    public void StoreItemBomb()
    {
        var Bomb = new Store();
        Bomb.name = "Bomb";
        Bomb.price = 100;
    }

    public void StoreItemFireStone()
    {
        var FireStone = new Store();
        FireStone.name = "FireStone";
        FireStone.price = 1000;
    }

    public void StoreItemIceStone()
    {
        var IceStone = new Store();
        IceStone.name = "IceStone";
        IceStone.price = 1000;
    }

    public void StoreItemEletricStone()
    {
        var EletricStone = new Store();
        EletricStone.name = "EletricStone";
        EletricStone.price = 1000;
    }

    public void StoreItemGeoStone()
    {
        var GeoStone = new Store();
        GeoStone.name = "GeoStone";
        GeoStone.price = 1000;
    }
}