using System;
using Raylib_cs;

namespace generalNamespace;


public class SpawnDestory
{
    Random rnd = new Random();
    public int maxEnemies = 5;
    public List<Enemy> entityList = new();
    public void SpawnEnemy(char entity) {
        switch(entity) {
            case '1':
                Enemy enemy = new Enemy();
                enemy.SetY(rnd.Next(0,1000));
                enemy.SetX(1500);
                enemy.SetRandomMoveSpeed();
                enemy.charImage = ImageService.SetEarthOneStartImage();
                entityList.Add(enemy);
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
    public List<Enemy> GetEntities() {
        return entityList;
    }
    public void makeEntitiesMove() {
        for(int i = 0; i < entityList.Count; i++) {
            entityList[i].MoveEntity();
            if (entityList[i].x < -50)
            {
                entityList.RemoveAt(i);
            }
        }
        
    }
    
}