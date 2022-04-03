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
    private readonly int waterBossOffsetW = 0;
    private readonly int waterBossOffsetH = 100;
    
    // Air boss collider box width and height offsets
    private readonly int airBossOffsetW = 20;
    private readonly int airBossOffsetH = 0;

    // Fire boss collider box width and height offsets
    private readonly int fireBossOffsetW = 60;
    private readonly int fireBossOffsetH = 0;

    // Shadow boss collider box width and height offsets
    private readonly int shadowBossOffsetW = 0;
    private readonly int shadowBossOffsetH = 20;
    
    public int maxEnemies = 5;
    public int maxReloadTime;
    public List<Weapon> playerWeaponList = new();
    private readonly Random rnd = new();

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
                var r = new Random();
                var enemyType = r.Next(1, 6);
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
        switch (level)
        {
            case 2:
                // Width and height offsets for collider box from lv 2 water boss texture file
                enemyBoss.offsetW = waterBossOffsetW;
                enemyBoss.offsetH = waterBossOffsetH;
                enemyBoss.SetCharTexture(ImageService.waterBossEnemyTexture);
                enemyBoss.levelOfEnemy = 2;
                break;
            case 3:
                // Width and height offsets for collider box from lv 3 air boss texture file
                enemyBoss.offsetW = airBossOffsetW;
                enemyBoss.offsetH = airBossOffsetH;
                enemyBoss.SetCharTexture(ImageService.airBossEnemyTexture);
                enemyBoss.levelOfEnemy = 3;
                break;
            case 4:
                // Width and height offsets for collider box from lv 4 fire boss texture file
                enemyBoss.offsetW = fireBossOffsetW;
                enemyBoss.offsetH = fireBossOffsetH;
                enemyBoss.SetCharTexture(ImageService.fireBossEnemyTexture);
                enemyBoss.levelOfEnemy = 4;
                break;
            case 5:
            // Width and height offsets for collider box from lv 5 shadow boss texture file
                enemyBoss.offsetW = shadowBossOffsetW;
                enemyBoss.offsetH = shadowBossOffsetH;
                enemyBoss.SetCharTexture(ImageService.shadowBossEnemyTexture);
                enemyBoss.levelOfEnemy = 5;
                break;
        }

        enemyBoss.SetOffsetColliderWidth(enemyBoss.offsetW);
        enemyBoss.SetOffsetColliderHeight(enemyBoss.offsetH);
        enemyBoss.SetY(rnd.Next(enemyBoss.GetTextureHeight(), VideoService.scrnHeight - enemyBoss.GetColliderBoxHeight()));
        enemyBoss.SetX(VideoService.scrnWidth + 100);
        enemyBoss.SetSpeedandHealth();
        enemyList.Add(enemyBoss);
    }
    public void SpawnEarthEnemy(int enemyDifficulty)
    {
        var enemyEarth = new Enemy();
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
        }

        else{
        switch (weaponType)
        {
            case 1:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser11Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 5;
                maxReloadTime = 450;

                break;
            case 2:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser10Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 10;
                maxReloadTime = 400;
                break;
            case 3:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser12Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 15;
                maxReloadTime = 350;
                break;
            case 4:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser9Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 20;
                maxReloadTime = 300;
                break;
            case 5:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser3Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 20;
                maxReloadTime = 250;
                break;
            case 6:
            // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser1Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 20;
                maxReloadTime = 200;
                break;
            case 7:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser5Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 25;
                maxReloadTime = 150;
                break;
            case 8:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.laser7Texture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 30;
                maxReloadTime = 100;
                break;
            case 9:
                // Load the weapon laser image when weapon purchased
                _weaponSwitcher.SetCharTexture(ImageService.coinCounterTexture);
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 999999;
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
            if (WeaponTypeID == 9)
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
                    PlayerStats.playerHealth = PlayerStats.maxPlayerHealth;
                    destroyed = true;
                } else if (PowerUpList[i].ID == 2)
                {
                    Powerup.IsShieldedEffect();
                    destroyed = true;
                }else if (PowerUpList[i].ID == 3)
                {
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
                && enemyList[i].laserCounter >= enemyList[i].laserMaxCount - 1)
            {
                CreateEnemyWeapon(i, enemyList[i]);
                enemyList[i].laserCounter = 0;
            }

            MakeEnemiesMove(i,player.y,player.x);
            // Removes an enemy if it moves off the left side of the screen
            RemoveEnemyOffScreen(i);
        }
        VideoService.DrawEnemyWeapons(enemyList, enemyWeaponsList);
    }
    public void CreateEnemyWeapon(int enemyI, Enemy enemy)
    { switch (enemy.levelOfEnemy)
        {
            case 1:
                var _EnemyWeaponOne = new Weapon();
                _EnemyWeaponOne.speed = 10;
                _EnemyWeaponOne.strength = 5;
                _EnemyWeaponOne.SetCharTexture(ImageService.laser11Texture);
                _EnemyWeaponOne.enemyIndex = enemyI;

                // Set and apply laser spawn location offset
                // _EnemyWeaponOne.SetOffsetColliderWidth(enemy.offsetW);
                // _EnemyWeaponOne.SetOffsetColliderHeight(enemy.offsetH);
                // _EnemyWeaponOne.SetX(enemy.x);
                // _EnemyWeaponOne.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

                AudioService.PlayAudio(AudioService.lv1Shot);
                enemyWeaponsList.Add(_EnemyWeaponOne);
                // VideoService.DrawEnemyWeapons(_EnemyWeaponOne.SetX, _EnemyWeaponOne.SetY);
                // DrawCharacter(EnemyWeaponsToDraw[i_weaponEnemy]);
                // DrawColliderBox(EnemyWeaponsToDraw[i_weaponEnemy]);

            break;
            case 2:
                var _EnemyWeaponTwo = new Weapon();
                _EnemyWeaponTwo.speed = 10;
                _EnemyWeaponTwo.strength = 10;
                _EnemyWeaponTwo.SetCharTexture(ImageService.laser10Texture);
                _EnemyWeaponTwo.enemyIndex = enemyI;

                // // Set and apply laser spawn location offset
                // _EnemyWeaponTwo.SetOffsetColliderWidth(enemy.offsetW);
                // _EnemyWeaponTwo.SetOffsetColliderHeight(enemy.offsetH);
                // _EnemyWeaponTwo.SetX(enemy.x);
                // _EnemyWeaponTwo.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

                AudioService.PlayAudio(AudioService.lv1Shot);
                enemyWeaponsList.Add(_EnemyWeaponTwo);
            break;
            case 3:
                var _EnemyWeaponThree = new Weapon();
                _EnemyWeaponThree.speed = 10;
                _EnemyWeaponThree.strength = 15;
                _EnemyWeaponThree.SetCharTexture(ImageService.laser12Texture);
                _EnemyWeaponThree.enemyIndex = enemyI;

                // Set and apply laser spawn location offset
                // _EnemyWeaponThree.SetOffsetColliderWidth(enemy.offsetW);
                // _EnemyWeaponThree.SetOffsetColliderHeight(enemy.offsetH);
                // _EnemyWeaponThree.SetX(enemy.x);
                // _EnemyWeaponThree.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

                AudioService.PlayAudio(AudioService.lv1Shot);
                enemyWeaponsList.Add(_EnemyWeaponThree);
            break;
        }
        // var _EnemyWeapon = new Weapon();
        // _EnemyWeapon.speed = 10;
        // _EnemyWeapon.SetCharTexture(ImageService.laser11Texture);
        // _EnemyWeapon.enemyIndex = enemyI;

        // // Set and apply laser spawn location offset
        // _EnemyWeapon.SetOffsetColliderWidth(enemy.offsetW);
        // _EnemyWeapon.SetOffsetColliderHeight(enemy.offsetH);
        // _EnemyWeapon.SetX(enemy.x);
        // _EnemyWeapon.SetY(enemy.y + enemy.GetColliderBoxHeight() / 2);

        // AudioService.PlayAudio(AudioService.lv1Shot);
        // enemyWeaponsList.Add(_EnemyWeapon);
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
    public void OnCollisionActionEnemyWeapon(Player player, Weapon weapon, int index)
    {
        if (collisionDetection.CheckCollision(player, weapon))
        {
            PlayerDeadCheck();
            if (!Powerup.isShielded)
            {
                PlayerStats.playerHealth -= weapon.strength;
            }
          
            enemyWeaponsList.RemoveAt(index);
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
                var c = new Coordinate();
                c.x = enemyList[enemyIndex].x;
                c.y = enemyList[enemyIndex].y;
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
    public void OnCollisionAction(Player player, int index)
    {
        if (collisionDetection.CheckCollision(player, enemyList[index]))
        {
            if (!Powerup.isShielded)
            {
                PlayerStats.playerHealth -= 50;
            }
            
            var c = new Coordinate();
            c.x = enemyList[index].x;
            c.y = enemyList[index].y;
            explosionCoordinates.Add(c);
            enemyList.RemoveAt(index);
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
        if(getPowerUp * chance <= 5){
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
            
            powerup.SetOffsetColliderWidth(enemy.offsetW);
            powerup.SetOffsetColliderHeight(enemy.offsetH);
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