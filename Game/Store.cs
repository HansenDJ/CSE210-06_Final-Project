using System;

using generalNamespace;

public class Store
{
    public string name;
    public int price;
    public void Ability(){}
    // public bool IsPurchased()
    // {
    //     IsPurchased = false
    // }
}
public class StoreList
{


    public void StoreItemHeart()
    {
        Store heart = new Store();
        heart.name = "Heart";
        heart.price = 100;
    }

    public void StoreItemFireRate()
    {
        Store FireRate = new Store();
        FireRate.name = "FireRate";
        FireRate.price = 100;
    }

    public void StoreItemMovementSpeed()
    {
        Store MovementSpeed = new Store();
        MovementSpeed.name = "MovementSpeed";
        MovementSpeed.price = 100;
    }

    public void StoreItemMissile()
    {
        Store Missile = new Store();
        Missile.name = "Missile";
        Missile.price = 100;
    }

    public void StoreItemBomb()
    {
        Store Bomb = new Store();
        Bomb.name = "Bomb";
        Bomb.price = 100;
    }

    public void StoreItemFireStone()
    {
        Store FireStone = new Store();
        FireStone.name = "FireStone";
        FireStone.price = 1000;
    }

    public void StoreItemIceStone()
    {
        Store IceStone = new Store();
        IceStone.name = "IceStone";
        IceStone.price = 1000;
    }

    public void StoreItemEletricStone()
    {
        Store EletricStone = new Store();
        EletricStone.name = "EletricStone";
        EletricStone.price = 1000;
    }
    public void StoreItemGeoStone()
    {
        Store GeoStone = new Store();
        GeoStone.name = "GeoStone";
        GeoStone.price = 1000;
    }

}