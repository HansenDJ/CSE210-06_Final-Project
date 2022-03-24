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
        switch (enemyDifficulty)
        {
            case 1:
                Enemy enemyEarthOne = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyEarthOne.offsetW = 10;
                enemyEarthOne.offsetH = 30;
                enemyEarthOne.SetOffsetColliderWidth(enemyEarthOne.offsetW);
                enemyEarthOne.SetOffsetColliderHeight(enemyEarthOne.offsetH);
                enemyEarthOne.SetY(rnd.Next(enemyEarthOne.GetImageHeight(), VideoService.scrnHeight - enemyEarthOne.GetColliderBoxHeight() * 2));
                enemyEarthOne.SetX(1500);
                enemyEarthOne.SetRandomMoveSpeed();
                enemyEarthOne.SetTexture(ImageService.SetEarthOneStartImage());


                entityList.Add(enemyEarthOne);
                break;
            case 2:
                Enemy enemyEarthTwo = new Enemy();
                 // Width and height offsets for collider box from enemy image file
                enemyEarthTwo.offsetW = 10;
                enemyEarthTwo.offsetH = 30;
                enemyEarthTwo.SetOffsetColliderWidth(enemyEarthTwo.offsetW);
                enemyEarthTwo.SetOffsetColliderHeight(enemyEarthTwo.offsetH);
                enemyEarthTwo.SetY(rnd.Next(enemyEarthTwo.GetImageHeight(), VideoService.scrnHeight - enemyEarthTwo.GetImageHeight()));
                enemyEarthTwo.SetX(1500);
                enemyEarthTwo.SetRandomMoveSpeed();
                enemyEarthTwo.SetTexture(ImageService.SetEarthTwoStartImage());

                entityList.Add(enemyEarthTwo);

                break;
            case 3:
                Enemy enemyEarthThree = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyEarthThree.offsetW = 10;
                enemyEarthThree.offsetH = 30;
                enemyEarthThree.SetOffsetColliderWidth(enemyEarthThree.offsetW);
                enemyEarthThree.SetOffsetColliderHeight(enemyEarthThree.offsetH);
                enemyEarthThree.SetY(rnd.Next(enemyEarthThree.GetImageHeight(), VideoService.scrnHeight - enemyEarthThree.GetImageHeight()));
                enemyEarthThree.SetX(1500);
                enemyEarthThree.SetRandomMoveSpeed();
                enemyEarthThree.SetTexture(ImageService.SetEarthTwoStartImage());

                entityList.Add(enemyEarthThree);
                break;
        }
    }

    public void SpawnWaterEnemy(int enemyDifficulty)
    {
        switch (enemyDifficulty)
        {
            case 1:
                Enemy enemyWaterOne = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyWaterOne.offsetW = 10;
                enemyWaterOne.offsetH = 30;
                enemyWaterOne.SetOffsetColliderWidth(enemyWaterOne.offsetW);
                enemyWaterOne.SetOffsetColliderHeight(enemyWaterOne.offsetH);
                enemyWaterOne.SetY(rnd.Next(enemyWaterOne.GetImageHeight(), VideoService.scrnHeight - enemyWaterOne.GetColliderBoxHeight() * 2));
                enemyWaterOne.SetX(1500);
                enemyWaterOne.SetRandomMoveSpeed();
                enemyWaterOne.SetTexture(ImageService.SetWaterOneStartImage());


                entityList.Add(enemyWaterOne);
                break;
            case 2:
                Enemy enemyWaterTwo = new Enemy();
                enemyWaterTwo.offsetW = 10;
                enemyWaterTwo.offsetH = 30;
                enemyWaterTwo.SetOffsetColliderWidth(enemyWaterTwo.offsetW);
                enemyWaterTwo.SetOffsetColliderHeight(enemyWaterTwo.offsetH);
                enemyWaterTwo.SetY(rnd.Next(enemyWaterTwo.GetImageHeight(), VideoService.scrnHeight - enemyWaterTwo.GetImageHeight()));
                enemyWaterTwo.SetX(1500);
                enemyWaterTwo.SetRandomMoveSpeed();
                enemyWaterTwo.SetTexture(ImageService.SetWaterTwoStartImage());

                entityList.Add(enemyWaterTwo);

                break;
            case 3:
                Enemy enemyWaterThree = new Enemy();
                enemyWaterThree.offsetW = 10;
                enemyWaterThree.offsetH = 30;
                enemyWaterThree.SetOffsetColliderWidth(enemyWaterThree.offsetW);
                enemyWaterThree.SetOffsetColliderHeight(enemyWaterThree.offsetH);
                enemyWaterThree.SetY(rnd.Next(enemyWaterThree.GetImageHeight(), VideoService.scrnHeight - enemyWaterThree.GetImageHeight()));
                enemyWaterThree.SetX(1500);
                enemyWaterThree.SetRandomMoveSpeed();
                enemyWaterThree.SetTexture(ImageService.SetWaterThreeStartImage());

                entityList.Add(enemyWaterThree);
                break;
        }
    }
    public void SpawnAirEnemy(int enemyDifficulty)
    {
        switch (enemyDifficulty)
        {
            case 1:
                Enemy enemyAirOne = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyAirOne.offsetW = 10;
                enemyAirOne.offsetH = 30;
                enemyAirOne.SetOffsetColliderWidth(enemyAirOne.offsetW);
                enemyAirOne.SetOffsetColliderHeight(enemyAirOne.offsetH);
                enemyAirOne.SetY(rnd.Next(enemyAirOne.GetImageHeight(), VideoService.scrnHeight - enemyAirOne.GetColliderBoxHeight() * 2));
                enemyAirOne.SetX(1500);
                enemyAirOne.SetRandomMoveSpeed();
                enemyAirOne.SetTexture(ImageService.SetAirOneStartImage());


                entityList.Add(enemyAirOne);
                break;
            case 2:
                Enemy enemyAirTwo = new Enemy();
                 // Width and height offsets for collider box from enemy image file
                enemyAirTwo.offsetW = 10;
                enemyAirTwo.offsetH = 30;
                enemyAirTwo.SetOffsetColliderWidth(enemyAirTwo.offsetW);
                enemyAirTwo.SetOffsetColliderHeight(enemyAirTwo.offsetH);
                enemyAirTwo.SetY(rnd.Next(enemyAirTwo.GetImageHeight(), VideoService.scrnHeight - enemyAirTwo.GetImageHeight()));
                enemyAirTwo.SetX(1500);
                enemyAirTwo.SetRandomMoveSpeed();
                enemyAirTwo.SetTexture(ImageService.SetAirTwoStartImage());

                entityList.Add(enemyAirTwo);

                break;
            case 3:
                Enemy enemyAirThree = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyAirThree.offsetW = 10;
                enemyAirThree.offsetH = 30;
                enemyAirThree.SetOffsetColliderWidth(enemyAirThree.offsetW);
                enemyAirThree.SetOffsetColliderHeight(enemyAirThree.offsetH);
                enemyAirThree.SetY(rnd.Next(enemyAirThree.GetImageHeight(), VideoService.scrnHeight - enemyAirThree.GetImageHeight()));
                enemyAirThree.SetX(1500);
                enemyAirThree.SetRandomMoveSpeed();
                enemyAirThree.SetTexture(ImageService.SetAirThreeStartImage());

                entityList.Add(enemyAirThree);
                break;
        }
    }

        public void SpawnFireEnemy(int enemyDifficulty)
    {
        switch (enemyDifficulty)
        {
            case 1:
                Enemy enemyFireOne = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyFireOne.offsetW = 10;
                enemyFireOne.offsetH = 30;
                enemyFireOne.SetOffsetColliderWidth(enemyFireOne.offsetW);
                enemyFireOne.SetOffsetColliderHeight(enemyFireOne.offsetH);
                enemyFireOne.SetY(rnd.Next(enemyFireOne.GetImageHeight(), VideoService.scrnHeight - enemyFireOne.GetColliderBoxHeight() * 2));
                enemyFireOne.SetX(1500);
                enemyFireOne.SetRandomMoveSpeed();
                enemyFireOne.SetTexture(ImageService.SetFireOneStartImage());


                entityList.Add(enemyFireOne);
                break;
            case 2:
                Enemy enemyFireTwo = new Enemy();
                enemyFireTwo.offsetW = 10;
                enemyFireTwo.offsetH = 30;
                enemyFireTwo.SetOffsetColliderHeight(enemyFireTwo.offsetH);
                enemyFireTwo.SetY(rnd.Next(enemyFireTwo.GetImageHeight(), VideoService.scrnHeight - enemyFireTwo.GetImageHeight()));
                enemyFireTwo.SetX(1500);
                enemyFireTwo.SetRandomMoveSpeed();
                enemyFireTwo.SetTexture(ImageService.SetFireTwoStartImage());

                entityList.Add(enemyFireTwo);

                break;
            case 3:
                Enemy enemyFireThree = new Enemy();
                enemyFireThree.offsetW = 10;
                enemyFireThree.offsetH = 30;
                enemyFireThree.SetOffsetColliderWidth(enemyFireThree.offsetW);
                enemyFireThree.SetOffsetColliderHeight(enemyFireThree.offsetH);
                enemyFireThree.SetY(rnd.Next(enemyFireThree.GetImageHeight(), VideoService.scrnHeight - enemyFireThree.GetImageHeight()));
                enemyFireThree.SetX(1500);
                enemyFireThree.SetRandomMoveSpeed();
                enemyFireThree.SetTexture(ImageService.SetFireThreeStartImage());

                entityList.Add(enemyFireThree);
                break;
        }
    }
       public void SpawnShadowEnemy(int enemyDifficulty)
    {
        switch (enemyDifficulty)
        {
            case 1:
                Enemy enemyShadowOne = new Enemy();
                // Width and height offsets for collider box from enemy image file
                enemyShadowOne.offsetW = 10;
                enemyShadowOne.offsetH = 30;
                enemyShadowOne.SetOffsetColliderWidth(enemyShadowOne.offsetW);
                enemyShadowOne.SetOffsetColliderHeight(enemyShadowOne.offsetH);
                enemyShadowOne.SetY(rnd.Next(enemyShadowOne.GetImageHeight(), VideoService.scrnHeight - enemyShadowOne.GetColliderBoxHeight() * 2));
                enemyShadowOne.SetX(1500);
                enemyShadowOne.SetRandomMoveSpeed();
                enemyShadowOne.SetTexture(ImageService.SetShadowOneStartImage());


                entityList.Add(enemyShadowOne);
                break;
            case 2:
                Enemy enemyShadowTwo = new Enemy();
                enemyShadowTwo.offsetW = 10;
                enemyShadowTwo.offsetH = 30;
                enemyShadowTwo.SetOffsetColliderHeight(enemyShadowTwo.offsetH);
                enemyShadowTwo.SetY(rnd.Next(enemyShadowTwo.GetImageHeight(), VideoService.scrnHeight - enemyShadowTwo.GetImageHeight()));
                enemyShadowTwo.SetX(1500);
                enemyShadowTwo.SetRandomMoveSpeed();
                enemyShadowTwo.SetTexture(ImageService.SetShadowTwoStartImage());

                entityList.Add(enemyShadowTwo);

                break;
            case 3:
                Enemy enemyShadowThree = new Enemy();
                enemyShadowThree.offsetW = 10;
                enemyShadowThree.offsetH = 30;
                enemyShadowThree.SetOffsetColliderWidth(enemyShadowThree.offsetW);
                enemyShadowThree.SetOffsetColliderHeight(enemyShadowThree.offsetH);
                enemyShadowThree.SetY(rnd.Next(enemyShadowThree.GetImageHeight(), VideoService.scrnHeight - enemyShadowThree.GetImageHeight()));
                enemyShadowThree.SetX(1500);
                enemyShadowThree.SetRandomMoveSpeed();
                enemyShadowThree.SetTexture(ImageService.SetShadowThreeStartImage());

                entityList.Add(enemyShadowThree);
                break;
        }
    }




    public void SpawnWeapon(char wType, Character target, Image weapon)
    {
        switch (wType)
        {
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
        for (int i = 0; i < entityList.Count - 1; i++)
        {
            OnCollisionAction(player, i);

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
    public void OnCollisionActionWeapon(Enemy player, Weapon weapon, int enemyIndex, int weaponIndex)
    {
        if (collisionDetection.CheckCollision(player, weapon))
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