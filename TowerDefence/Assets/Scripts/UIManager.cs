using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public EnemyWaveSpawner enemyWaveSpawner;
    public void SelectTowerType(int towerType)
    {
        TowerType type = (TowerType)towerType;
        BuildManager.instance.SetTowerToBuild(type);
    }
    public void ReleaseSpawn()
    {
        enemyWaveSpawner.SpawnAWave();
    }
}
