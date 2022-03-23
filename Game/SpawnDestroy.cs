using System;
using generalNamespace.Laser;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;


public class SpawnDestory
{
    Random rnd = new Random();
    VideoService vd = new VideoService();
    CollisionDetection collisionDetection = new CollisionDetection();
    Enemy enemy = new Enemy();
    private Weapon _weapon = new Weapon();
    public List<Enemy> entityList = new();
    public List<Weapon> WeaponList = new();
    public void SpawnEnemy(char entity) {
        switch(entity) {
            case '1':
                enemy.SetY(rnd.Next(enemy.GetImageHeight(), VideoService.scrnHeight - enemy.GetImageHeight()));
                enemy.SetX(1500);
                enemy.SetRandomMoveSpeed();
                enemy.SetImage(ImageService.SetEarthOneStartImage());
                
                entityList.Add(enemy);
                break;
            case '2':
               
                break;
            case '3':
               
                break;
        }
    }
    public void SpawnWeapon(char wType, Character target, Image weapon) {
        switch(wType) {
            case '1':
                _weapon.SetY(target.y);
                _weapon.SetX(target.x);
                _weapon.SetImage(weapon);
                WeaponList.Add(_weapon);
                break;
            case '2':
               
                break;
            case '3':
               
                break;
        }
    }

    public bool CheckIfSpawnNeeded()
    {
        return (enemy.maxEnemies - (entityList.Count - 1) > 0);
    }

    // Create a list of the artifacts on the screen
    public List<Enemy> GetEntities()
    {
        return entityList;
    }

    public List<Weapon> getWeapons()
    {
        return WeaponList;
    }

    // Loop through all the enemies on the screen inside the entityList
    public void EntityListLoop(Player player)
    {
        for(int i = 0; i < entityList.Count - 1; i++)
        {
            OnCollisionAction(player, i);
            MakeEntitiesMove(i);
        }
    }
    public void MakeEntitiesMove(int index)
    {
        entityList[index].MoveEntity();
        // Remove an enemy if it moves off the left side of the screen
        if(entityList[index].x < -50)
        {
            entityList.RemoveAt(index);
        }
    }
    public void MakeWeaponsMove()
    {
        for (int index = 0; index < WeaponList.Count; index++)
        {
            WeaponList[index].MoveWeaponRight();
            // Remove an enemy if it moves off the left side of the screen
            if(WeaponList[index].x < -50 || WeaponList[index].x > 1450)
            {
                WeaponList.RemoveAt(index);
            }
        }
     
    }

    // Occurs when the player collides with an enemy
    public void OnCollisionAction(Player player, int index)
    {
        if(collisionDetection.CheckCollision(player, entityList[index]))
        {
            // TEST: Remove enemy if collides with player
            entityList.RemoveAt(index);
        }
    }
    
}