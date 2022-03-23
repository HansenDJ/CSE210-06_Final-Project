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
    
    public List<Enemy> entityList = new();
    public List<Weapon> WeaponList = new();
    public int maxEnemies = 5;
    public void SpawnEnemy(char entity) {
        switch(entity) {
            case '1':
                Enemy enemy = new Enemy();
                enemy.SetY(rnd.Next(enemy.GetImageHeight(), VideoService.scrnHeight - enemy.GetImageHeight()));
                enemy.SetX(1500);
                enemy.SetRandomMoveSpeed();
                enemy.SetTexture(ImageService.SetEarthOneStartImage());
                
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
                Weapon _weapon = new Weapon();
                _weapon.SetY(target.y);
                _weapon.SetX(target.x);
                _weapon.SetTexture(weapon);
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
        return (maxEnemies - (entityList.Count - 1) > 0);
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
        for (int index = 0; index < WeaponList.Count - 1 ; index++)
        {
            WeaponList[index].MoveWeaponRight();
            for (int j = 0; j < entityList.Count - 1; j++)
            {
                if (collisionDetection.CheckCollision(entityList[j], WeaponList[index]))
                {
                    OnCollisionActionWeapon(entityList[j],WeaponList[index],j,index);
                }
            }
            if(WeaponList[index].x < -50 || WeaponList[index].x > 1450)
            {
                WeaponList.RemoveAt(index);
            }
        }
     
    }
    public void OnCollisionActionWeapon(Enemy player, Weapon weapon,int enemyIndex,int weaponIndex)
    {
        if(collisionDetection.CheckCollision(player, weapon))
        {
            entityList.RemoveAt(enemyIndex);
            WeaponList.RemoveAt(weaponIndex);
            // TEST: Remove enemy if collides with player
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