using System;
using generalNamespace.Laser;

namespace generalNamespace;

public class SpawnDestory
{
    private readonly CollisionDetection collisionDetection = new();

    public List<Enemy> enemyList = new();
    public List<Weapon> enemyWeaponsList = new();
    public List<Coordinate> explosionCoordinates = new();
    public List<PowerUpGraphic> PowerUpList = new();
    public List<Weapon> playerWeaponList = new();
    private readonly Random rnd = new();

    // Level 1 enemy collider box width and height offsets
    private readonly int lvOneEnemyOffsetW = 18;
    private readonly int lvOneEnemyOffsetH = 14;

    // Level 2 enemy collider box width and height offsets
    private readonly int lvTwoEnemyOffsetW = 30;
    private readonly int lvTwoEnemyOffsetH = 10;

    // Level 3 enemy collider box width and height offsets
    private readonly int lvThreeEnemyOffsetW = 30;
    private readonly int lvThreeEnemyOffsetH = 10;

    // Water boss collider box width and height offsets
    private readonly int waterBossOffsetW = 35;
    private readonly int waterBossOffsetH = 190;
    
    // Air boss collider box width and height offsets
    private readonly int airBossOffsetW = 75;
    private readonly int airBossOffsetH = 15;

    // Fire boss collider box width and height offsets
    private readonly int fireBossOffsetW = 155;
    private readonly int fireBossOffsetH = 240;

    // Shadow boss collider box width and height offsets
    private readonly int shadowBossOffsetW = 85;
    private readonly int shadowBossOffsetH = 320;
    
    public static int enemyIDCounter = 0;
    public int maxEnemies = 5;
    public int maxReloadTime;

    public int getPowerUp;

    public int setPowerUp;

    private int RandomEnemy()
    {
        return rnd.Next(1, 4); // Enemy difficulty is 1, 2, or 3
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
            default:
                int enemyType = rnd.Next(1, 6);
                switch (enemyType)
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

                break;
        }
    }

    public void SpawnBoss(int level)
    {
        var enemyBoss = new Enemy();
        enemyBoss.health = 800 * level;
        enemyBoss.enemyID = enemyIDCounter;
        enemyIDCounter++;
        if (DifficultyHandler.currentLevel > 5)
        {
            level = rnd.Next(2, 6);
        }
        switch (level)
        {
            case 2:
                spawnWaterBoss(enemyBoss);
                break;
            case 3:
                spawnAirBoss(enemyBoss);
                break;
            case 4:
                spawnFireBoss(enemyBoss);
                break;
            case 5:
                spawnShadowBoss(enemyBoss);
                break;
            // Chooses a random boss each level after level 5
            default:
                int randomBoss = rnd.Next(2,6);
                switch(randomBoss)
                {
                    case 2:
                        spawnWaterBoss(enemyBoss);
                        break;
                    case 3:
                        spawnAirBoss(enemyBoss);
                        break;
                    case 4:
                        spawnFireBoss(enemyBoss);
                        break;
                    case 5:
                        spawnShadowBoss(enemyBoss);
                        break;
                }
                break;
                
        }

        enemyBoss.SetOffsetColliderWidth(enemyBoss.offsetW);
        enemyBoss.SetOffsetColliderHeight(enemyBoss.offsetH);
        enemyBoss.SetY(400);
        enemyBoss.SetX(VideoService.scrnWidth + 100);
        enemyBoss.moveSpeed = 1;
        int chaseSpeedLimit = rnd.Next(1,2 * level);
        if (chaseSpeedLimit >= 10)
        {
            chaseSpeedLimit = 10;
        }

        enemyBoss.chaseSpeed = chaseSpeedLimit;
        enemyBoss.levelOfEnemy = 100;
        enemyList.Add(enemyBoss);
    }
    private void spawnWaterBoss(Enemy waterBossEnemy)
    {
        // Width and height offsets for collider box from lv 2 water boss texture file
        waterBossEnemy.offsetW = waterBossOffsetW;
        waterBossEnemy.offsetH = waterBossOffsetH;
        waterBossEnemy.SetCharTexture(ImageService.waterBossEnemyTexture);
    }
    private void spawnAirBoss(Enemy airBossEnemy)
    {
        // Width and height offsets for collider box from lv 3 air boss texture file
        airBossEnemy.offsetW = airBossOffsetW;
        airBossEnemy.offsetH = airBossOffsetH;
        airBossEnemy.SetCharTexture(ImageService.airBossEnemyTexture);
    }
    private void spawnFireBoss(Enemy fireBossEnemy)
    {
        // Width and height offsets for collider box from lv 4 fire boss texture file
        fireBossEnemy.offsetW = fireBossOffsetW;
        fireBossEnemy.offsetH = fireBossOffsetH;
        fireBossEnemy.SetCharTexture(ImageService.fireBossEnemyTexture);
    }
    private void spawnShadowBoss(Enemy shadowBossEnemy)
    {
        // Width and height offsets for collider box from lv 5 shadow boss texture file
        shadowBossEnemy.offsetW = shadowBossOffsetW;
        shadowBossEnemy.offsetH = shadowBossOffsetH;
        shadowBossEnemy.SetCharTexture(ImageService.shadowBossEnemyTexture);
    }

    
    public void SpawnEarthEnemy(int enemyDifficulty)
    {
        var enemyEarth = new Enemy();
        enemyEarth.enemyID = enemyIDCounter;
        enemyIDCounter++;
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
        enemyEarth.SetY(rnd.Next(enemyEarth.GetTextureHeight(), VideoService.scrnHeight - enemyEarth.GetColliderBoxHeight()));
        enemyEarth.SetX(VideoService.scrnWidth + 100);
        enemyEarth.SetSpeedandHealth();
        enemyList.Add(enemyEarth);
    }

    public void SpawnWaterEnemy(int enemyDifficulty)
    {
        var enemyWater = new Enemy();
        enemyWater.enemyID = enemyIDCounter;
        enemyIDCounter++;
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 water enemy image file
                enemyWater.offsetW = lvOneEnemyOffsetW;
                enemyWater.offsetH = lvOneEnemyOffsetH;
                enemyWater.SetCharTexture(ImageService.waterOneEnemyTexture);
                enemyWater.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 water enemy image file
                enemyWater.offsetW = lvTwoEnemyOffsetW;
                enemyWater.offsetH = lvTwoEnemyOffsetH;
                enemyWater.SetCharTexture(ImageService.waterTwoEnemyTexture);
                enemyWater.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 water enemy image file
                enemyWater.offsetW = lvThreeEnemyOffsetW;
                enemyWater.offsetH = lvThreeEnemyOffsetH;
                enemyWater.SetCharTexture(ImageService.waterThreeEnemyTexture);
                enemyWater.levelOfEnemy = 3;
                break;
        }

        enemyWater.SetOffsetColliderWidth(enemyWater.offsetW);
        enemyWater.SetOffsetColliderHeight(enemyWater.offsetH);
        enemyWater.SetY(rnd.Next(enemyWater.GetTextureHeight(), VideoService.scrnHeight - enemyWater.GetColliderBoxHeight()));
        enemyWater.SetX(VideoService.scrnWidth + 100);
        enemyWater.SetSpeedandHealth();
        enemyList.Add(enemyWater);
    }

    public void SpawnAirEnemy(int enemyDifficulty)
    {
        var enemyAir = new Enemy();
        enemyAir.enemyID = enemyIDCounter;
        enemyIDCounter++;
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 air enemy image file
                enemyAir.offsetW = lvOneEnemyOffsetW;
                enemyAir.offsetH = lvOneEnemyOffsetH;
                enemyAir.SetCharTexture(ImageService.airOneEnemyTexture);
                enemyAir.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 air enemy image file
                enemyAir.offsetW = lvTwoEnemyOffsetW;
                enemyAir.offsetH = lvTwoEnemyOffsetH;
                enemyAir.SetCharTexture(ImageService.airTwoEnemyTexture);
                enemyAir.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 air enemy image file
                enemyAir.offsetW = lvThreeEnemyOffsetW;
                enemyAir.offsetH = lvThreeEnemyOffsetH;
                enemyAir.SetCharTexture(ImageService.airThreeEnemyTexture);
                enemyAir.levelOfEnemy = 3;
                break;
        }

        enemyAir.SetOffsetColliderWidth(enemyAir.offsetW);
        enemyAir.SetOffsetColliderHeight(enemyAir.offsetH);
        enemyAir.SetY(rnd.Next(enemyAir.GetTextureHeight(), VideoService.scrnHeight - enemyAir.GetColliderBoxHeight()));
        enemyAir.SetX(VideoService.scrnWidth + 100);
        enemyAir.SetSpeedandHealth();
        enemyList.Add(enemyAir);
    }

    public void SpawnFireEnemy(int enemyDifficulty)
    {
        var enemyFire = new Enemy();
        enemyFire.enemyID = enemyIDCounter;
        enemyIDCounter++;
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 fire enemy image file
                enemyFire.offsetW = lvOneEnemyOffsetW;
                enemyFire.offsetH = lvOneEnemyOffsetH;
                enemyFire.SetCharTexture(ImageService.fireOneEnemyTexture);
                enemyFire.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 fire enemy image file
                enemyFire.offsetW = lvTwoEnemyOffsetW;
                enemyFire.offsetH = lvTwoEnemyOffsetH;
                enemyFire.SetCharTexture(ImageService.fireTwoEnemyTexture);
                enemyFire.levelOfEnemy = 2;
                break;
            case 3:
                enemyFire.offsetW = lvThreeEnemyOffsetW;
                enemyFire.offsetH = lvThreeEnemyOffsetH;
                enemyFire.SetCharTexture(ImageService.fireThreeEnemyTexture);
                enemyFire.levelOfEnemy = 3;
                break;
        }

        enemyFire.SetOffsetColliderWidth(enemyFire.offsetW);
        enemyFire.SetOffsetColliderHeight(enemyFire.offsetH);
        enemyFire.SetY(rnd.Next(enemyFire.GetTextureHeight(), VideoService.scrnHeight - enemyFire.GetColliderBoxHeight()));
        enemyFire.SetX(VideoService.scrnWidth + 100);
        enemyFire.SetSpeedandHealth();
        enemyList.Add(enemyFire);
    }

    public void SpawnShadowEnemy(int enemyDifficulty)
    {
        var enemyShadow = new Enemy();
        enemyShadow.enemyID = enemyIDCounter;
        enemyIDCounter++;
        switch (enemyDifficulty)
        {
            case 1:
                // Width and height offsets for collider box from lv 1 shadow enemy image file
                enemyShadow.offsetW = lvOneEnemyOffsetW;
                enemyShadow.offsetH = lvOneEnemyOffsetH;
                enemyShadow.SetCharTexture(ImageService.shadowOneEnemyTexture);
                enemyShadow.levelOfEnemy = 1;
                break;
            case 2:
                // Width and height offsets for collider box from lv 2 shadow enemy image file
                enemyShadow.offsetW = lvTwoEnemyOffsetW;
                enemyShadow.offsetH = lvTwoEnemyOffsetH;
                enemyShadow.SetCharTexture(ImageService.shadowTwoEnemyTexture);
                enemyShadow.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 shadow enemy image file
                enemyShadow.offsetW = lvThreeEnemyOffsetW;
                enemyShadow.offsetH = lvThreeEnemyOffsetH;
                enemyShadow.SetCharTexture(ImageService.shadowThreeEnemyTexture);
                enemyShadow.levelOfEnemy = 3;
                break;
        }

        enemyShadow.SetOffsetColliderWidth(enemyShadow.offsetW);
        enemyShadow.SetOffsetColliderHeight(enemyShadow.offsetH);
        enemyShadow.SetY(rnd.Next(enemyShadow.GetTextureHeight(), VideoService.scrnHeight - enemyShadow.GetColliderBoxHeight()));
        enemyShadow.SetX(VideoService.scrnWidth + 100);
        enemyShadow.SetSpeedandHealth();
        enemyList.Add(enemyShadow);
    }

    private int WeaponTypeID = 0;

    public void SpawnWeapon(int weaponType, int custom = 1,int customX = 0,int customY = 0)
    {
        WeaponTypeID = weaponType;
        var _weaponSwitcher = new Weapon();
        _weaponSwitcher.powerUpShot = custom;
        _weaponSwitcher.direction = custom;
        if (custom != 1)
        {
            _weaponSwitcher.SetX(customX);
            _weaponSwitcher.SetY(customY);
            _weaponSwitcher.SetCharTexture(ImageService.laser10UpTexture);
            playerWeaponList.Add(_weaponSwitcher);
            _weaponSwitcher.strength = 5;
            AudioService.PlayAudio(AudioService.bounceShot);
        }

        else{
        switch (weaponType)
        {
            case 1:
                AudioService.PlayAudio(AudioService.playershot1);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser11Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 7;
                maxReloadTime = 400;

                break;
            case 2:
                AudioService.PlayAudio(AudioService.playershot2);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser10Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 12;
                maxReloadTime = 400;
                break;
            case 3:
                AudioService.PlayAudio(AudioService.playershot3);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser12Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 15;
                maxReloadTime = 350;
                break;
            case 4:
                AudioService.PlayAudio(AudioService.playershot4);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser9Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 15;
                maxReloadTime = 300;
                break;
            case 5:
                AudioService.PlayAudio(AudioService.playershot5);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser3Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 18;
                maxReloadTime = 250;
                break;
            case 6:
                AudioService.PlayAudio(AudioService.playershot6);
            // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser1Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 20;
                maxReloadTime = 200;
                break;
            case 7:
                AudioService.PlayAudio(AudioService.playershot7);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser5Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 20;
                maxReloadTime = 150;
                break;
            case 8:
                AudioService.PlayAudio(AudioService.playershot8);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser7Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 25;
                maxReloadTime = 100;
                break;
            case 9:
                AudioService.PlayAudio(AudioService.playershot8);
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser7Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 30;
                maxReloadTime = 70;
                break;
            case 10:
              
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.coinCounterTexture);
                AudioService.PlayAudio(AudioService.playershot9);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 100;
                maxReloadTime = 100;
                break;
        }}
    }

    public void IncrementReloadTime()
    {
        Weapon.reloadTime += 20;
    }

    public void ShootWeapon(Player playerToShoot)
    {
        if (Weapon.reloadTime >= maxReloadTime)
        {
           
            
            SpawnWeapon(CurrencyHandler.CheckMoney());
            if (WeaponTypeID == 10)
            {
                CurrencyHandler.money -= 25;
            }
            
            Weapon.reloadTime = 0;
        }
    }

    public bool CheckIfSpawnNeeded()
    {
        // Return true if size of enemyList is less than maxEnemies number
        return enemyList.Count <= maxEnemies;
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
        for (var i = 0; i < explosionCoordinates.Count; i++)
        {
            explosionCoordinates[i].frame += 1;
            if (explosionCoordinates[i].frame > 15) explosionCoordinates.RemoveAt(i);
        }

        return explosionCoordinates;
    }

    // Loop through all the enemies on the screen inside the enemyList
    public void PowerUpFall(Player player)
    {
        for (int i = 0; i < PowerUpList.Count; i++)
        {
            PowerUpList[i].Fall();
            bool destroyed = false;
            if(collisionDetection.CheckCollision(PowerUpList[i],player))
            {
               
                if (PowerUpList[i].ID == 1)
                {
                    if (PlayerStats.playerHealth <= PlayerStats.maxPlayerHealth / 2)
                    {
                        AudioService.PlayAudio(AudioService.healPlayer);
                        PlayerStats.playerHealth = PlayerStats.maxPlayerHealth / 2;
                    }
                    destroyed = true;
                } else if (PowerUpList[i].ID == 2)
                {
                    AudioService.PlayAudio(AudioService.shieldPlayer);
                    Powerup.IsShieldedEffect();
                    destroyed = true;
                }else if (PowerUpList[i].ID == 3)
                {
                    AudioService.PlayAudio(AudioService.bounceShot);
                    Powerup.IsExplosiveEffect();
                    destroyed = true;

                }
            }
            if (PowerUpList[i].y > 1000 || destroyed)
            {
                PowerUpList.Remove(PowerUpList[i]);
            }
        }
    }
    public  void EnemyListLoop(Player player)
    {
        for (var i = 0; i < enemyList.Count - 1; i++)
        {
            OnCollisionAction(player, i);
            enemyList[i].laserCounter += 9;
                // ERROR Only spawn weapon when player alive
                // Check if enemy is within range set from the players y and enemy is to the right of player
            if (player.y - 100 <= enemyList[i].y
                && enemyList[i].y <= player.y + 100
                && enemyList[i].x >= player.x + player.offsetColliderWidth
                && enemyList[i].laserCounter >= enemyList[i].laserMaxCount)
            {
                // levelOfEnemy must be set by this point for switch case
                CreateEnemyWeapon(i, enemyList[i]);
                enemyList[i].laserCounter = 0;
            }

            if (enemyList[i].levelOfEnemy == 100 && enemyList[i].x < 952)
            {
                enemyList[i].moveSpeed = 0;
            }
            VideoService.DrawEnemyWeapons(i, enemyList, enemyWeaponsList);
            MakeEnemiesMove(i,player.y,player.x);
            // Removes an enemy if it moves off the left side of the screen
            RemoveEnemyOffScreen(i);
        }
    }
    public void CreateEnemyWeapon(int enemyI, Enemy enemy)
    {
        Weapon enemyWeaponToCreate = new Weapon();
        enemyWeaponToCreate.laserID = enemy.enemyID;
        // levelOfEnemy must be set by this point for switch case
        switch (enemy.levelOfEnemy)
        {
            case 1:
                enemyWeaponToCreate.speed = 10;
                enemyWeaponToCreate.strength = 5;
                enemyWeaponToCreate.SetCharTexture(ImageService.laser11Texture);
                // enemyWeaponToCreate.enemyIndex = enemyI;
                // enemy.laserIndex = enemyWeaponToCreate.enemyIndex;
                enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
                enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);

                AudioService.PlayAudio(AudioService.playershot5);
                enemyWeaponsList.Add(enemyWeaponToCreate);

            break;
            case 2:
                
                enemyWeaponToCreate.speed = 10;
                enemyWeaponToCreate.strength = 10;
                enemyWeaponToCreate.SetCharTexture(ImageService.laser10Texture);
                // enemyWeaponToCreate.enemyIndex = enemyI;
                // enemy.laserIndex = enemyWeaponToCreate.enemyIndex;
                enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
                enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);

                // // Set and apply laser spawn location offset
                // enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
                // enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);
                // enemyWeaponToCreate.SetX(enemy.x);
                // enemyWeaponToCreate.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

                AudioService.PlayAudio(AudioService.playershot4);
                enemyWeaponsList.Add(enemyWeaponToCreate);
            break;
            case 3:
                enemyWeaponToCreate.speed = 10;
                enemyWeaponToCreate.strength = 15;
                enemyWeaponToCreate.SetCharTexture(ImageService.laser12Texture);
                // enemyWeaponToCreate.enemyIndex = enemyI;
                // enemy.laserIndex = enemyWeaponToCreate.enemyIndex;
                enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
                enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);

                // Set and apply laser spawn location offset
                // enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
                // enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);
                // enemyWeaponToCreate.SetX(enemy.x);
                // enemyWeaponToCreate.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

                AudioService.PlayAudio(AudioService.playershot3);
                enemyWeaponsList.Add(enemyWeaponToCreate);
            break;
            default :
                int shotcount = rnd.Next(1,5);
  
                for (int i = 0; i < shotcount; i++)
                {
                    Weapon enemyWeaponToCreate2 = new Weapon();
                    enemyWeaponToCreate2.laserID = enemy.enemyID;
                    EnemyBossShot(enemy, enemyWeaponToCreate2);
                    int shotChoice = rnd.Next(1, 3);
                    switch (shotChoice)
                    {
                        case 1:
                        AudioService.PlayAudio(AudioService.bossShot1);
                        break;
                            case 2:
                                AudioService.PlayAudio(AudioService.bossShot2);
                                break;
                    }
                    
                }

               
                EnemyBossShot(enemy, enemyWeaponToCreate);
                


                break;
        }
        // enemyWeaponToCreate.speed = 10;
        // enemyWeaponToCreate.SetCharTexture(ImageService.laser11Texture);
        // enemyWeaponToCreate.enemyIndex = enemyI;

        // // Set and apply laser spawn location offset
        // enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
        // enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);
        // enemyWeaponToCreate.SetX(enemy.x);
        // enemyWeaponToCreate.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

        // AudioService.PlayAudio(AudioService.lv1Shot);
        // enemyWeaponsList.Add(enemyWeaponToCreate);
    }

    private void EnemyBossShot(Enemy enemy, Weapon enemyWeaponToCreate)
    {
        enemyWeaponToCreate.speed = rnd.Next(6,15);
        enemyWeaponToCreate.strength = 50;
        enemyWeaponToCreate.SetCharTexture(ImageService.laser8Texture);
        enemyWeaponToCreate.randomBossWeaponY = rnd.Next(50, enemy.GetColliderBoxHeight() - 50);

        // enemyWeaponToCreate.enemyIndex = enemyI;
        // enemy.laserIndex = enemyWeaponToCreate.enemyIndex;

        // Set and apply laser spawn location offset
        // enemyWeaponToCreate.SetOffsetColliderWidth(enemy.offsetW);
        // enemyWeaponToCreate.SetOffsetColliderHeight(enemy.offsetH);
        // enemyWeaponToCreate.SetX(enemy.x);
        // enemyWeaponToCreate.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

       
        enemyWeaponsList.Add(enemyWeaponToCreate);
    }

    public void PlayExplosion()
    {
        int explosionSound = rnd.Next(1, 10);
        switch (explosionSound)
        {
            case 1:
                AudioService.PlayAudio(AudioService.explosion1);
                break;
            case 2:
                AudioService.PlayAudio(AudioService.explosion2);
                break;
            case 3:
                AudioService.PlayAudio(AudioService.explosion3);
                break;
            case 4 :
                AudioService.PlayAudio(AudioService.explosion4);
                break;
            case 5:
                AudioService.PlayAudio(AudioService.explosion5);
                break;
            case 6:
                AudioService.PlayAudio(AudioService.explosion6);
                break;
            case 7:
                AudioService.PlayAudio(AudioService.explosion7);
                break;
            case 8:
                AudioService.PlayAudio(AudioService.explosion8);
                break;
            case 9:
                AudioService.PlayAudio(AudioService.explosion9);
                break;
        }
    }

    public void MakeEnemiesMove(int index, int playery,int playerx)
    {
        enemyList[index].MoveEnemy(playery, playerx);
    }

    // Removes an enemy if it moves off the left side of the screen
    private void RemoveEnemyOffScreen(int removeIndex)
    {
        if (enemyList[removeIndex].x < -50)
        {
           
            enemyList.RemoveAt(removeIndex);
           
        }
    }

   

    public void MakePlayerWeaponsMove()
    {
        for (var index = 0; index < playerWeaponList.Count - 1; index++)
        {
            playerWeaponList[index].ChooseWeaponDirectionandMove();
            for (var j = 0; j < enemyList.Count - 1; j++)
                if (collisionDetection.CheckCollision(enemyList[j], playerWeaponList[index]))
                    OnCollisionActionPlayerWeapon(enemyList[j], playerWeaponList[index], j, index);
            if (playerWeaponList[index].x < -50 || playerWeaponList[index].x > VideoService.scrnWidth + 50 || playerWeaponList[index].y < 0 || playerWeaponList[index].y > VideoService.scrnHeight + 50) playerWeaponList.RemoveAt(index);
        }
    }

    public void MakeEnemyWeaponsMove(Player player)
    {
        for (var index = 0; index < enemyWeaponsList.Count - 1; index++)
        {
            enemyWeaponsList[index].ChooseWeaponDirectionandMove();

            if (collisionDetection.CheckCollision(player, enemyWeaponsList[index]))
                OnCollisionActionEnemyWeapon(player, enemyWeaponsList[index], index);
            if (enemyWeaponsList[index].x < -50 || enemyWeaponsList[index].x > VideoService.scrnWidth) enemyWeaponsList.RemoveAt(index);
        }
    }

    public void PlayerDeadCheck()
    {
        if (PlayerStats.playerHealth <= 0) PlayerStats.playerHealth = 0;
        
    }

    // When enemy laser hits the player, damage the player and remove laser
    public void OnCollisionActionEnemyWeapon(Player player, Weapon weapon, int i_weapon)
    {
        if (collisionDetection.CheckCollision(player, weapon))
        {
            PlayerDeadCheck();
            if (!Powerup.isShielded)
            {
                PlayerStats.playerHealth -= weapon.strength;
                AudioService.PlayAudio(AudioService.hurtPlayer);
            }
          
            enemyWeaponsList.RemoveAt(i_weapon);
        }
    }

    public void SetRandomMoney(int enemyLevelNumber)
    {
        switch (enemyLevelNumber)
        {
            case 1:
                CurrencyHandler.randomMoney = rnd.Next(1, 5);
                break;
            case 2:
                CurrencyHandler.randomMoney = rnd.Next(6, 10);
                break;
            case 3:
                CurrencyHandler.randomMoney = rnd.Next(11, 15);
                break;
            case 100:
                CurrencyHandler.randomMoney = 500;
                break;
        }
    }

    public void OnCollisionActionPlayerWeapon(
        Enemy enemy,
        Weapon weapon,
        int enemyIndex,
        int weaponIndex
    )
    {
        if (collisionDetection.CheckCollision(enemy, weapon))
        {
            // Decrement enemy health here
            // Add an if statement that checks if enemy health is zero
            enemyList[enemyIndex].health -= weapon.strength;
            if (enemyList[enemyIndex].health <= 0)
            {
                PlayExplosion();
                var c = new Coordinate();
                c.x = enemyList[enemyIndex].x + enemyList[enemyIndex].GetTextureWidth() / 2;
                c.y = enemyList[enemyIndex].y + enemyList[enemyIndex].GetTextureHeight() / 2;
                explosionCoordinates.Add(c);
                
                SetRandomMoney(enemyList[enemyIndex].levelOfEnemy);
                CurrencyHandler.money += CurrencyHandler.randomMoney;
                SetRandomPowerUp(enemyList[enemyIndex].levelOfEnemy, enemyList[enemyIndex]);

                enemyList.RemoveAt(enemyIndex);
            }

            if (Powerup.isExplosiveShot)
            {
               SpawnWeapon(2,2,enemy.x,enemy.y);
               SpawnWeapon(2,3,enemy.x,enemy.y);
               
            }
            // Change so that the weapon is destroyed when the enemy health goes to zero
            playerWeaponList.RemoveAt(weaponIndex);
        }
    }

    // Occurs when the player collides with an enemy
    public void OnCollisionAction(Player player, int i_enemy)
    {
        if (collisionDetection.CheckCollision(player, enemyList[i_enemy]))
        {
            PlayExplosion();
            if (!Powerup.isShielded)
            {
                PlayerStats.playerHealth -= 50;
                AudioService.PlayAudio(AudioService.hurtPlayer);
            }

            if (enemyList[i_enemy].levelOfEnemy == 100)
            {
                
            }
            else
            {
                var c = new Coordinate();
                c.x = enemyList[i_enemy].x;
                c.y = enemyList[i_enemy].y;
                explosionCoordinates.Add(c);
                enemyList.RemoveAt(i_enemy);
            }
           
        }
            // TEST: Remove enemy if collides with player
            //Player.playerHealth = Player.playerHealth -10;
    }

    public void ClearMap()
    {
        enemyList.Clear();
        playerWeaponList.Clear();
        enemyWeaponsList.Clear();
        explosionCoordinates.Clear();
        maxEnemies = 5;
    }
  
    public void SetRandomPowerUp(int chance, Enemy enemy)
    {
        getPowerUp = rnd.Next(1,25);
        if(getPowerUp * chance <= 5)
        {
            setPowerUp = rnd.Next(1,4);
            PowerUpGraphic powerup = new PowerUpGraphic();
            switch (setPowerUp)
            {
            case 1:
                powerup.SetCharTexture(ImageService.powerUpHealthTexture);
                break;
            case 2:
                powerup.SetCharTexture(ImageService.powerUpShieldTexture);
                break;
            case 3:
                powerup.SetCharTexture(ImageService.powerUpRicochetTexture);
                break;
            }
           
            powerup.ID = setPowerUp;
            
            powerup.SetX(enemy.x + enemy.GetColliderBoxWidth());
            powerup.SetY(enemy.y + enemy.GetColliderBoxHeight());
            
           
         
            PowerUpList.Add(powerup);
        }
        
    }

    public List<PowerUpGraphic> GetPowerUps()
    {
        return PowerUpList;
    }



}