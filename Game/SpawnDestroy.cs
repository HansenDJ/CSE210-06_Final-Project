using generalNamespace.Laser;

namespace generalNamespace;

public class SpawnDestory
{
    private readonly CollisionDetection collisionDetection = new();

    public List<Enemy> enemyList = new();
    public List<Weapon> enemyWeaponsList = new();
    public List<Coordinate> explosionCoordinates = new();
    private readonly int lvOneEnemyOffsetH = 14;

    // Level 1 enemy collider box width and height offsets
    private readonly int lvOneEnemyOffsetW = 18;
    private readonly int lvThreeEnemyOffsetH = 10;

    // Level 3 enemy collider box width and height offsets
    private readonly int lvThreeEnemyOffsetW = 30;
    private readonly int lvTwoEnemyOffsetH = 10;

    // Level 2 enemy collider box width and height offsets
    private readonly int lvTwoEnemyOffsetW = 30;
    public int maxEnemies = 5;
    public int maxReloadTime;
    public List<Weapon> playerWeaponList = new();
    private readonly Random rnd = new();

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
                var enemyType = r.Next(1, 5);
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
        enemyEarth.SetY(rnd.Next(enemyEarth.GetTextureHeight(), VideoService.scrnHeight - enemyEarth.GetColliderBoxHeight() * 2));
        enemyEarth.SetX(1500);
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
        enemyWater.SetY(rnd.Next(enemyWater.GetTextureHeight(), VideoService.scrnHeight - enemyWater.GetColliderBoxHeight() * 2));
        enemyWater.SetX(1500);
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
        enemyAir.SetY(rnd.Next(enemyAir.GetTextureHeight(), VideoService.scrnHeight - enemyAir.GetColliderBoxHeight() * 2));
        enemyAir.SetX(1500);
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
        enemyFire.SetY(rnd.Next(enemyFire.GetTextureHeight(), VideoService.scrnHeight - enemyFire.GetColliderBoxHeight() * 2));
        enemyFire.SetX(1500);
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
        enemyShadow.SetY(rnd.Next(enemyShadow.GetTextureHeight(), VideoService.scrnHeight - enemyShadow.GetColliderBoxHeight() * 2));
        enemyShadow.SetX(1500);
        enemyShadow.SetSpeedandHealth();
        enemyList.Add(enemyShadow);
    }

    public void SpawnWeapon(int weaponType, Character target)
    {
        var _weaponSwitcher = new Weapon();
        switch (weaponType)
        {
            case 1:
                _weaponSwitcher.SetCharTexture(ImageService.laser1Texture); // Load the weapon laser image when weapon purchased
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 5;
                maxReloadTime = 400;

                break;
            case 2:
                _weaponSwitcher.SetCharTexture(ImageService.laser3Texture); // Load the weapon laser image when weapon purchased
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 10;
                maxReloadTime = 300;
                break;
            case 3:
                _weaponSwitcher.SetCharTexture(ImageService.laser5Texture); // Load the weapon laser image when weapon purchased
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 15;
                maxReloadTime = 200;
                break;
            case 4:
                _weaponSwitcher.SetCharTexture(ImageService.laser7Texture); // Load the weapon laser image when weapon purchased
                playerWeaponList.Add(_weaponSwitcher);
                _weaponSwitcher.strength = 20;
                maxReloadTime = 100;
                break;
        }
    }

    public void IncrementReloadTime()
    {
        Weapon.reloadTime += 20;
    }

    public void ShootWeapon(Player playerToShoot)
    {
        if (Weapon.reloadTime >= maxReloadTime)
        {
            SpawnWeapon(CurrencyHandler.CheckMoney(), playerToShoot);
            Weapon.reloadTime = 0;
        }
    }

    public bool CheckIfSpawnNeeded()
    {
        // Return true if size of enemyList is less than maxEnemies number
        return enemyList.Count < maxEnemies;
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
    public async void EnemyListLoop(Player player)
    {
        for (var i = 0; i < enemyList.Count - 1; i++)
        {
            OnCollisionAction(player, i);
            enemyList[i].laserCounter += 20;
            if (player.y - 100 <= enemyList[i].y
                && enemyList[i].y <= player.y + 100
                && enemyList[i].x >= player.x + player.offsetColliderWidth
                && enemyList[i].laserCounter >= enemyList[i].laserMaxCount)
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
        var _EnemyWeapon = new Weapon();
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
        if (enemyList[removeIndex].x < -50) enemyList.RemoveAt(removeIndex);
    }

    public void MakePlayerWeaponsMove()
    {
        for (var index = 0; index < playerWeaponList.Count - 1; index++)
        {
            playerWeaponList[index].MoveWeaponRight();
            for (var j = 0; j < enemyList.Count - 1; j++)
                if (collisionDetection.CheckCollision(enemyList[j], playerWeaponList[index]))
                    OnCollisionActionPlayerWeapon(enemyList[j], playerWeaponList[index], j, index);
            if (playerWeaponList[index].x < -50 || playerWeaponList[index].x > 1450) playerWeaponList.RemoveAt(index);
        }
    }

    public void MakeEnemyWeaponsMove(Player player)
    {
        for (var index = 0; index < enemyWeaponsList.Count - 1; index++)
        {
            enemyWeaponsList[index].ChooseWeaponDirectionandMove();

            if (collisionDetection.CheckCollision(player, enemyWeaponsList[index]))
                OnCollisionActionEnemyWeapon(player, enemyWeaponsList[index], index);
            if (enemyWeaponsList[index].x < -50 || enemyWeaponsList[index].x > 1450) enemyWeaponsList.RemoveAt(index);
        }
    }

    public void PlayerDeadCheck()
    {
        if (PlayerStats.playerHealth <= 0) PlayerStats.playerHealth = 0;
    }

    // When enemy hit by a laser, damage the player and remove laser
    public void OnCollisionActionEnemyWeapon(Player player, Weapon weapon, int index)
    {
        if (collisionDetection.CheckCollision(player, weapon))
        {
            PlayerDeadCheck();
            PlayerStats.playerHealth -= weapon.strength;
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

                if (enemyList[enemyIndex].levelOfEnemy == 1)
                {
                    SetRandomMoney(enemyList[enemyIndex].levelOfEnemy);
                    CurrencyHandler.money += CurrencyHandler.randomMoney;
                }
                else if (enemyList[enemyIndex].levelOfEnemy == 2)
                {
                    SetRandomMoney(enemyList[enemyIndex].levelOfEnemy);
                    CurrencyHandler.money += CurrencyHandler.randomMoney;
                }
                else if (enemyList[enemyIndex].levelOfEnemy == 3)
                {
                    SetRandomMoney(enemyList[enemyIndex].levelOfEnemy);
                    CurrencyHandler.money += CurrencyHandler.randomMoney;
                }

                // Change so that the enemy is destroyed when the enemy health goes to zero
                enemyList.RemoveAt(enemyIndex);
            }

            if (Powerup.isExplosiveShot)
            {
               
            }
            // Change so that the weapon is destroyed when the enemy health goes to zero
            playerWeaponList.RemoveAt(weaponIndex);
        }
    }

    // Occurs when the player collides with an enemy
    public void OnCollisionAction(Player player, int index)
    {
        if (collisionDetection.CheckCollision(player, enemyList[index]))
            // TEST: Remove enemy if collides with player
            enemyList.RemoveAt(index);
    }

    public void ClearMap()
    {
        enemyList.Clear();
        playerWeaponList.Clear();
        enemyWeaponsList.Clear();
        explosionCoordinates.Clear();
        maxEnemies = 5;
    }
}