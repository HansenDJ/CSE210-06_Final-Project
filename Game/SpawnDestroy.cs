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
    public List<Weapon> EnemyWeaponsList = new();
    public int maxEnemies = 5;

    // Level 1 enemy collider box width and height offsets
    private int lvOneEnemyOffsetW = 18;
    private int lvOneEnemyOffsetH = 14;
    // Level 2 enemy collider box width and height offsets
    private int lvTwoEnemyOffsetW = 30;
    private int lvTwoEnemyOffsetH = 10;
    // Level 3 enemy collider box width and height offsets
    private int lvThreeEnemyOffsetW = 30;
    private int lvThreeEnemyOffsetH = 10;

    private int RandomEntity()
    {
        return rnd.Next(1, 4);   // Enemy difficulty is 1, 2, or 3
    }

    public void SpawnEnemy(int level)
    {
        switch (level)
        {
            case 1:
                SpawnEarthEnemy(RandomEntity());
                break;
            case 2:
                SpawnWaterEnemy(RandomEntity());
                break;
            case 3:
                SpawnAirEnemy(RandomEntity());    
                break;
            case 4:
                SpawnFireEnemy(RandomEntity());
                break;
            case 5:
                SpawnShadowEnemy(RandomEntity());
                break;
        }
    }

    public void SpawnEarthEnemy(int enemyDifficulty)
    {
        Enemy enemyEarth = new Enemy();
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 earth enemy image file
                enemyEarth.offsetW = lvOneEnemyOffsetW;
                enemyEarth.offsetH = lvOneEnemyOffsetH;
                enemyEarth.SetTexture(ImageService.SetEarthOneStartImage());
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 earth enemy image file
                enemyEarth.offsetW = lvTwoEnemyOffsetW;
                enemyEarth.offsetH = lvTwoEnemyOffsetH;
                enemyEarth.SetTexture(ImageService.SetEarthTwoStartImage());
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 earth enemy image file
                enemyEarth.offsetW = lvThreeEnemyOffsetW;
                enemyEarth.offsetH = lvThreeEnemyOffsetH;
                enemyEarth.SetTexture(ImageService.SetEarthThreeStartImage());
                break;
        }
        enemyEarth.SetOffsetColliderWidth(enemyEarth.offsetW);
        enemyEarth.SetOffsetColliderHeight(enemyEarth.offsetH);
        enemyEarth.SetY(rnd.Next(enemyEarth.GetImageHeight(), VideoService.scrnHeight - enemyEarth.GetColliderBoxHeight() * 2));
        enemyEarth.SetX(1500);
        enemyEarth.SetRandomMoveSpeed();
        entityList.Add(enemyEarth);
    }

    public void SpawnWaterEnemy(int enemyDifficulty)
    {
        Enemy enemyWater = new Enemy();
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 water enemy image file
                enemyWater.offsetW = lvOneEnemyOffsetW;
                enemyWater.offsetH = lvOneEnemyOffsetH;
                enemyWater.SetTexture(ImageService.SetWaterOneStartImage());
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 water enemy image file
                enemyWater.offsetW = lvTwoEnemyOffsetW;
                enemyWater.offsetH = lvTwoEnemyOffsetH;
                enemyWater.SetTexture(ImageService.SetWaterTwoStartImage());
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 water enemy image file
                enemyWater.offsetW = lvThreeEnemyOffsetW;
                enemyWater.offsetH = lvThreeEnemyOffsetH;
                enemyWater.SetTexture(ImageService.SetWaterThreeStartImage());
                break;
        }
        enemyWater.SetOffsetColliderWidth(enemyWater.offsetW);
        enemyWater.SetOffsetColliderHeight(enemyWater.offsetH);
        enemyWater.SetY(rnd.Next(enemyWater.GetImageHeight(), VideoService.scrnHeight - enemyWater.GetColliderBoxHeight() * 2));
        enemyWater.SetX(1500);
        enemyWater.SetRandomMoveSpeed();
        entityList.Add(enemyWater);
    }
    public void SpawnAirEnemy(int enemyDifficulty)
    {
        Enemy enemyAir = new Enemy();
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 air enemy image file
                enemyAir.offsetW = lvOneEnemyOffsetW;
                enemyAir.offsetH = lvOneEnemyOffsetH;
                enemyAir.SetTexture(ImageService.SetAirOneStartImage());
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 air enemy image file
                enemyAir.offsetW = lvTwoEnemyOffsetW;
                enemyAir.offsetH = lvTwoEnemyOffsetH;
                enemyAir.SetTexture(ImageService.SetAirTwoStartImage());
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 air enemy image file
                enemyAir.offsetW = lvThreeEnemyOffsetW;
                enemyAir.offsetH = lvThreeEnemyOffsetH;
                enemyAir.SetTexture(ImageService.SetAirThreeStartImage());
                break;
        }
        enemyAir.SetOffsetColliderWidth(enemyAir.offsetW);
        enemyAir.SetOffsetColliderHeight(enemyAir.offsetH);
        enemyAir.SetY(rnd.Next(enemyAir.GetImageHeight(), VideoService.scrnHeight - enemyAir.GetColliderBoxHeight() * 2));
        enemyAir.SetX(1500);
        enemyAir.SetRandomMoveSpeed();
        entityList.Add(enemyAir);
    }

    
    public void SpawnFireEnemy(int enemyDifficulty)
    {
        Enemy enemyFire = new Enemy();
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 fire enemy image file
                enemyFire.offsetW = lvOneEnemyOffsetW;
                enemyFire.offsetH = lvOneEnemyOffsetH;
                enemyFire.SetTexture(ImageService.SetFireOneStartImage());
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 fire enemy image file
                enemyFire.offsetW = lvTwoEnemyOffsetW;
                enemyFire.offsetH = lvTwoEnemyOffsetH;
                enemyFire.SetTexture(ImageService.SetFireTwoStartImage());
                break;
            case 3:
                enemyFire.offsetW = lvThreeEnemyOffsetW;
                enemyFire.offsetH = lvThreeEnemyOffsetH;
                enemyFire.SetTexture(ImageService.SetFireThreeStartImage());
                break;
        }
        enemyFire.SetOffsetColliderWidth(enemyFire.offsetW);
        enemyFire.SetOffsetColliderHeight(enemyFire.offsetH);
        enemyFire.SetY(rnd.Next(enemyFire.GetImageHeight(), VideoService.scrnHeight - enemyFire.GetColliderBoxHeight() * 2));
        enemyFire.SetX(1500);
        enemyFire.SetRandomMoveSpeed();
        entityList.Add(enemyFire);
    }
    public void SpawnShadowEnemy(int enemyDifficulty)
    {
        Enemy enemyShadow = new Enemy();
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 shadow enemy image file
                enemyShadow.offsetW = lvOneEnemyOffsetW;
                enemyShadow.offsetH = lvOneEnemyOffsetH;
                enemyShadow.SetTexture(ImageService.SetShadowOneStartImage());
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 shadow enemy image file
                enemyShadow.offsetW = lvTwoEnemyOffsetW;
                enemyShadow.offsetH = lvTwoEnemyOffsetH;
                enemyShadow.SetTexture(ImageService.SetShadowTwoStartImage());
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 shadow enemy image file
                enemyShadow.offsetW = lvThreeEnemyOffsetW;
                enemyShadow.offsetH = lvThreeEnemyOffsetH;
                enemyShadow.SetTexture(ImageService.SetShadowThreeStartImage());
                break;
        }
        enemyShadow.SetOffsetColliderWidth(enemyShadow.offsetW);
        enemyShadow.SetOffsetColliderHeight(enemyShadow.offsetH);
        enemyShadow.SetY(rnd.Next(enemyShadow.GetImageHeight(), VideoService.scrnHeight - enemyShadow.GetColliderBoxHeight() * 2));
        enemyShadow.SetX(1500);
        enemyShadow.SetRandomMoveSpeed();
        entityList.Add(enemyShadow);
    }




    public void SpawnWeapon(char wType, Character target, Image weapon)
    {
        switch (wType)
        {
            case '1':
                Weapon _weapon = new Weapon();
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

    // Create a list of the enemies on the screen
    public List<Enemy> GetEntities()
    {
        return entityList;
    }

    public List<Weapon> getWeapons()
    {
        return WeaponList;
    }

    public List<Weapon> getEnemyWeapons()
    {
        return EnemyWeaponsList;
    }

    // Loop through all the enemies on the screen inside the entityList
    public void EntityListLoop(Player player)
    {
        for (int i = 0; i < entityList.Count - 1; i++)
        {
            OnCollisionAction(player, i);
            if (entityList[i].y - player.y < 100)
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 100);
                if (chance > 95)
                {
                    Weapon _EnemyWeapon = new Weapon();
                    _EnemyWeapon.speed = 10;
                    _EnemyWeapon.SetTexture(ImageService.SetLazers3());
                    _EnemyWeapon.x = entityList[i].x;
                    _EnemyWeapon.y = entityList[i].y;
                    EnemyWeaponsList.Add(_EnemyWeapon);
                }
             
              
            }
            MakeEntitiesMove(i);
        }
    }
    public void MakeEntitiesMove(int index)
    {
        entityList[index].MoveEntity();
        // Remove an enemy if it moves off the left side of the screen
        if (entityList[index].x < -50)
        {
            entityList.RemoveAt(index);
        }
    }
    public void MakeWeaponsMove()
    {
        for (int index = 0; index < WeaponList.Count - 1; index++)
        {
            WeaponList[index].MoveWeaponRight();
            for (int j = 0; j < entityList.Count - 1; j++)
            {
                if (collisionDetection.CheckCollision(entityList[j], WeaponList[index]))
                {
                    OnCollisionActionWeapon(entityList[j], WeaponList[index], j, index);
                }
            }
            if (WeaponList[index].x < -50 || WeaponList[index].x > 1450)
            {
                WeaponList.RemoveAt(index);
            }
        }

    }
    public void MakeEnemyWeaponsMove(Player player)
    {
        for (int index = 0; index < EnemyWeaponsList.Count - 1; index++)
        {
            EnemyWeaponsList[index].MoveWeaponLeft();
            
                if (collisionDetection.CheckCollision(player, EnemyWeaponsList[index]))
                {
                    OnCollisionActionEnemyWeapon(player, EnemyWeaponsList[index],index);
                }
                if (EnemyWeaponsList[index].x < -50 || EnemyWeaponsList[index].x > 1450)
            {
               EnemyWeaponsList.RemoveAt(index);
            }
        }

    }

    public void OnCollisionActionEnemyWeapon(Player player, Weapon weapon, int index)
    {
        if (collisionDetection.CheckCollision(player, weapon))
        {
            Playerstats.playerHealth -= 5;
            if (Playerstats.playerHealth <= 0)
            {
                Console.WriteLine("Died");
            }
            EnemyWeaponsList.RemoveAt(index);
        }
    }

    public void OnCollisionActionWeapon(Enemy enemy, Weapon weapon, int enemyIndex, int weaponIndex)
    {
        if (collisionDetection.CheckCollision(enemy, weapon))
        {
            entityList[enemyIndex].health -= weapon.strength;
            if (entityList[enemyIndex].health <= 0)
            {
                entityList.RemoveAt(enemyIndex);
            }
            WeaponList.RemoveAt(weaponIndex);
            // TEST: Remove enemy if collides with player
        }
    }


    // Occurs when the player collides with an enemy
    public void OnCollisionAction(Player player, int index)
    {
        if (collisionDetection.CheckCollision(player, entityList[index]))
        {
            // TEST: Remove enemy if collides with player
            entityList.RemoveAt(index);
        }
    }

}