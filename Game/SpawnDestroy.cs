using System;
using generalNamespace.Laser;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;


public class SpawnDestory
{
    Random rnd = new Random();
    CollisionDetection collisionDetection = new CollisionDetection();

    public List<Enemy> enemyList = new();
    public List<Weapon> playerWeaponList = new();
    public List<Weapon> enemyWeaponsList = new();
    public List<Coordinate> explosionCoordinates = new();
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

    private int RandomEnemy()
    {
        return rnd.Next(1, 4);   // Enemy difficulty is 1, 2, or 3
    }

    public void SpawnEnemy(int level)
    {
        switch (level)
        {
            case 1:
                SpawnEarthEnemy(RandomEnemy());
                break;
            case 2:
                SpawnWaterEnemy(RandomEnemy());
                break;
            case 3:
                SpawnAirEnemy(RandomEnemy());    
                break;
            case 4:
                SpawnFireEnemy(RandomEnemy());
                break;
            case 5:
                SpawnShadowEnemy(RandomEnemy());
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
                enemyEarth.SetCharTexture(ImageService.earthOneEnemyTexture);
                enemyEarth.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 earth enemy image file
                enemyEarth.offsetW = lvTwoEnemyOffsetW;
                enemyEarth.offsetH = lvTwoEnemyOffsetH;
                enemyEarth.SetCharTexture(ImageService.earthTwoEnemyTexture);
                enemyEarth.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 earth enemy image file
                enemyEarth.offsetW = lvThreeEnemyOffsetW;
                enemyEarth.offsetH = lvThreeEnemyOffsetH;
                enemyEarth.SetCharTexture(ImageService.earthThreeEnemyTexture);
                enemyEarth.levelOfEnemy = 3;
                break;
        }
        enemyEarth.SetOffsetColliderWidth(enemyEarth.offsetW);
        enemyEarth.SetOffsetColliderHeight(enemyEarth.offsetH);
        enemyEarth.SetY(rnd.Next(enemyEarth.GetTextureHeight(), VideoService.scrnHeight - enemyEarth.GetColliderBoxHeight() * 2));
        enemyEarth.SetX(1500);
        enemyEarth.SetRandomMoveSpeed();
        enemyList.Add(enemyEarth);
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
                enemyWater.SetCharTexture(ImageService.waterOneEnemyTexture);
                enemyWater.levelOfEnemy =1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 water enemy image file
                enemyWater.offsetW = lvTwoEnemyOffsetW;
                enemyWater.offsetH = lvTwoEnemyOffsetH;
                enemyWater.SetCharTexture(ImageService.waterTwoEnemyTexture);
                enemyWater.levelOfEnemy =2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 water enemy image file
                enemyWater.offsetW = lvThreeEnemyOffsetW;
                enemyWater.offsetH = lvThreeEnemyOffsetH;
                enemyWater.SetCharTexture(ImageService.waterThreeEnemyTexture);
                enemyWater.levelOfEnemy =3;
                break;
        }
        enemyWater.SetOffsetColliderWidth(enemyWater.offsetW);
        enemyWater.SetOffsetColliderHeight(enemyWater.offsetH);
        enemyWater.SetY(rnd.Next(enemyWater.GetTextureHeight(), VideoService.scrnHeight - enemyWater.GetColliderBoxHeight() * 2));
        enemyWater.SetX(1500);
        enemyWater.SetRandomMoveSpeed();
        enemyList.Add(enemyWater);
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
                ImageService.GetTexture(ImageService.airOneEnemyTexture);
                enemyAir.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 air enemy image file
                enemyAir.offsetW = lvTwoEnemyOffsetW;
                enemyAir.offsetH = lvTwoEnemyOffsetH;
                ImageService.GetTexture(ImageService.airTwoEnemyTexture);
                enemyAir.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 air enemy image file
                enemyAir.offsetW = lvThreeEnemyOffsetW;
                enemyAir.offsetH = lvThreeEnemyOffsetH;
                ImageService.GetTexture(ImageService.airThreeEnemyTexture);
                enemyAir.levelOfEnemy = 3;
                break;
        }
        enemyAir.SetOffsetColliderWidth(enemyAir.offsetW);
        enemyAir.SetOffsetColliderHeight(enemyAir.offsetH);
        enemyAir.SetY(rnd.Next(enemyAir.GetTextureHeight(), VideoService.scrnHeight - enemyAir.GetColliderBoxHeight() * 2));
        enemyAir.SetX(1500);
        enemyAir.SetRandomMoveSpeed();
        enemyList.Add(enemyAir);
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
                ImageService.GetTexture(ImageService.fireOneEnemyTexture);
                enemyFire.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 fire enemy image file
                enemyFire.offsetW = lvTwoEnemyOffsetW;
                enemyFire.offsetH = lvTwoEnemyOffsetH;
                ImageService.GetTexture(ImageService.fireTwoEnemyTexture);
                enemyFire.levelOfEnemy = 2;
                break;
            case 3:
                enemyFire.offsetW = lvThreeEnemyOffsetW;
                enemyFire.offsetH = lvThreeEnemyOffsetH;
                ImageService.GetTexture(ImageService.fireThreeEnemyTexture);
                enemyFire.levelOfEnemy = 3;
                break;
        }
        enemyFire.SetOffsetColliderWidth(enemyFire.offsetW);
        enemyFire.SetOffsetColliderHeight(enemyFire.offsetH);
        enemyFire.SetY(rnd.Next(enemyFire.GetTextureHeight(), VideoService.scrnHeight - enemyFire.GetColliderBoxHeight() * 2));
        enemyFire.SetX(1500);
        enemyFire.SetRandomMoveSpeed();
        enemyList.Add(enemyFire);
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
                ImageService.GetTexture(ImageService.shadowOneEnemyTexture);
                enemyShadow.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 shadow enemy image file
                enemyShadow.offsetW = lvTwoEnemyOffsetW;
                enemyShadow.offsetH = lvTwoEnemyOffsetH;
                ImageService.GetTexture(ImageService.shadowTwoEnemyTexture);
                enemyShadow.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 shadow enemy image file
                enemyShadow.offsetW = lvThreeEnemyOffsetW;
                enemyShadow.offsetH = lvThreeEnemyOffsetH;
                ImageService.GetTexture(ImageService.shadowThreeEnemyTexture);
                enemyShadow.levelOfEnemy = 3;
                break;
        }
        enemyShadow.SetOffsetColliderWidth(enemyShadow.offsetW);
        enemyShadow.SetOffsetColliderHeight(enemyShadow.offsetH);
        enemyShadow.SetY(rnd.Next(enemyShadow.GetTextureHeight(), VideoService.scrnHeight - enemyShadow.GetColliderBoxHeight() * 2));
        enemyShadow.SetX(1500);
        enemyShadow.SetRandomMoveSpeed();
        enemyList.Add(enemyShadow);
    }

    public void SpawnWeapon(char weaponType, Character target, Texture2D weaponTexture)
    {
        switch (weaponType)
        {
            case '1':
                Weapon _weapon = new Weapon();
                _weapon.SetCharTexture(weaponTexture); // Load the weapon laser image when weapon purchased
                playerWeaponList.Add(_weapon);

                break;
            case '2':

                break;
            case '3':

                break;
        }
    }

    public bool CheckIfSpawnNeeded()
    {
        return (maxEnemies - (enemyList.Count - 1) > 0);
    }

    // Create a list of the enemies on the screen
    public List<Enemy> GetEnemies()
    {
        return enemyList;
    }

    public List<Weapon> getPlayerWeapons()
    {
        return playerWeaponList;
    }

    public List<Weapon> getEnemyWeapons()
    {
        return enemyWeaponsList;
    }

    public List<Coordinate> getExplosions()
    {
        for (int i = 0; i < explosionCoordinates.Count; i++)
        {
            explosionCoordinates[i].frame += 1;
            if (explosionCoordinates[i].frame > 15)
            {
                explosionCoordinates.RemoveAt(i);
            }
        }
        return explosionCoordinates;
    }

    // Loop through all the enemies on the screen inside the enemyList
    public async void EnemyListLoop(Player player)
    {
        for (int i = 0; i < enemyList.Count - 1; i++)
        {
            OnCollisionAction(player, i);
            enemyList[i].laserCounter += 20;
            if (((player.y - 100 <= enemyList[i].y) && (enemyList[i].y <= player.y + 100)) && enemyList[i].laserCounter >= enemyList[i].laserMaxCount)
            {
                CreateEnemyWeapon(i, enemyList[i]);
                enemyList[i].laserCounter = 0;
            }
            MakeEnemiesMove(i);
            RemoveEnemy(i);
        }
    }
    public void CreateEnemyWeapon(int enemyI, Enemy enemy)
    {
        Weapon _EnemyWeapon = new Weapon();
        _EnemyWeapon.speed = 10;
        _EnemyWeapon.SetCharTexture(ImageService.laser11Texture);
        _EnemyWeapon.enemyIndex = enemyI;

        // Set and apply laser spawn location offset
        _EnemyWeapon.SetOffsetColliderWidth(enemy.offsetW);
        _EnemyWeapon.SetOffsetColliderHeight(enemy.offsetH);
        _EnemyWeapon.SetX(enemy.x - enemy.GetColliderBoxWidth());
        _EnemyWeapon.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);
        
        AudioService.PlayAudio(AudioService.lv1Shot);
        enemyWeaponsList.Add(_EnemyWeapon);
    }
    public void MakeEnemiesMove(int index)
    {
        enemyList[index].MoveEnemy();
    }
    private void RemoveEnemy(int removeIndex)
    {
        // Remove an enemy if it moves off the left side of the screen
        if (enemyList[removeIndex].x < -50)
        {
            enemyList.RemoveAt(removeIndex);
        }
    }
    public void MakePlayerWeaponsMove()
    {
        for (int index = 0; index < playerWeaponList.Count - 1; index++)
        {
            playerWeaponList[index].MoveWeaponRight();
            for (int j = 0; j < enemyList.Count - 1; j++)
            {
                if (collisionDetection.CheckCollision(enemyList[j], playerWeaponList[index]))
                {
                    OnCollisionActionPlayerWeapon(enemyList[j], playerWeaponList[index], j, index);
                }
            }
            if (playerWeaponList[index].x < -50 || playerWeaponList[index].x > 1450)
            {
                playerWeaponList.RemoveAt(index);
            }
        }

    }
    public void MakeEnemyWeaponsMove(Player player)
    {
        for (int index = 0; index < enemyWeaponsList.Count - 1; index++)
        {
            enemyWeaponsList[index].MoveWeaponLeft();
            
                if (collisionDetection.CheckCollision(player, enemyWeaponsList[index]))
                {
                    OnCollisionActionEnemyWeapon(player, enemyWeaponsList[index],index);
                }
                if (enemyWeaponsList[index].x < -50 || enemyWeaponsList[index].x > 1450)
                {
                    enemyWeaponsList.RemoveAt(index);
                }
        }

    }

    public void OnCollisionActionEnemyWeapon(Player player, Weapon weapon, int index)
    {
        if (collisionDetection.CheckCollision(player, weapon))
        {
            PlayerStats.playerHealth -= 5;
            if (PlayerStats.playerHealth <= 0)
            {
                Console.WriteLine("Died");
            }
            enemyWeaponsList.RemoveAt(index);
        }
    }

    public void OnCollisionActionPlayerWeapon(Enemy enemy, Weapon weapon, int enemyIndex, int weaponIndex)
    {
        if (collisionDetection.CheckCollision(enemy, weapon))
        {
            // Decrement enemy health here
            // Add an if statement that checks if enemy health is zero
            enemyList[enemyIndex].health -= weapon.strength;
            if (enemyList[enemyIndex].health <= 0)
            {
                Coordinate c = new Coordinate();
                c.x = enemyList[enemyIndex].x;
                c.y = enemyList[enemyIndex].y;
                explosionCoordinates.Add(c);

                enemyList.RemoveAt(enemyIndex);  // Change so that the enemy is destroyed when the enemy health goes to zero
            }
            playerWeaponList.RemoveAt(weaponIndex);  // Change so that the weapon is destroyed when the enemy health goes to zero
        }
    }


    // Occurs when the player collides with an enemy
    public void OnCollisionAction(Player player, int index)
    {
        if (collisionDetection.CheckCollision(player, enemyList[index]))
        {
            // TEST: Remove enemy if collides with player
            enemyList.RemoveAt(index);
        }
    }

}