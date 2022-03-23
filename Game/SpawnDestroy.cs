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
    public List<Weapon> weaponList = new();
    public int maxEnemies = 5;
    public void SpawnEnemy(char entity) {
        switch(entity) {
            case '1':
                Enemy enemy = new Enemy();
                enemy.SetY(rnd.Next(0, VideoService.scrnHeight - enemy.GetColliderBoxWidth() * 2));
                enemy.SetX(VideoService.scrnWidth + enemy.GetImageWidth());
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
    public void SpawnWeapon(char weaponType, Character target, Image weapon) {
        switch(weaponType) {
            case '1':
                Weapon _weapon = new Weapon();
                _weapon.SetY(target.y);
                _weapon.SetX(target.x);
                _weapon.SetTexture(weapon);
                weaponList.Add(_weapon);
               
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
        return weaponList;
    }

    // Loop through all the enemies on the screen inside the entityList
    public void EntityListLoop(Player player)
    {
        for(int i_entity = 0; i_entity < entityList.Count - 1; i_entity++)
        {
            OnCollisionAction(player, i_entity);
            
            MakeEntitiesMove(i_entity);
        }
    }
    public void MakeEntitiesMove(int i_moveEntity)
    {
        entityList[i_moveEntity].MoveEntity();
        // Remove an enemy if it moves off the left side of the screen
        if(entityList[i_moveEntity].x < -50)
        {
            entityList.RemoveAt(i_moveEntity);
        }
    }
    public void MakeWeaponsMove()
    {
        for (int i_moveWeapon = 0; i_moveWeapon < weaponList.Count - 1 ; i_moveWeapon++)
        {
            weaponList[i_moveWeapon].MoveWeaponRight();
            for (int j = 0; j < entityList.Count - 1; j++)
            {
                if (collisionDetection.CheckCollision(entityList[j], weaponList[i_moveWeapon]))
                {
                    OnCollisionActionWeapon(entityList[j],weaponList[i_moveWeapon],j,i_moveWeapon);
                }
            }
            if(weaponList[i_moveWeapon].x < -50 || weaponList[i_moveWeapon].x > 1450)
            {
                weaponList.RemoveAt(i_moveWeapon);
            }
        }
     
    }
    public void OnCollisionActionWeapon(Enemy player, Weapon weapon,int i_enemy,int i_weapon)
    {
        if(collisionDetection.CheckCollision(player, weapon))
        {
            entityList.RemoveAt(i_enemy);
            weaponList.RemoveAt(i_weapon);
            // TEST: Remove enemy if collides with player
        }
    }
    

    // Occurs when the player collides with an enemy
    public void OnCollisionAction(Player player, int i_collision)
    {
        if(collisionDetection.CheckCollision(player, entityList[i_collision]))
        {
            // TEST: Remove enemy if collides with player
            entityList.RemoveAt(i_collision);
        }
    }
    
}