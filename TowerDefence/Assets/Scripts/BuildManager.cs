using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject cannonTowerPrefab;
    public GameObject mortarTowerPrefab;
    public GameObject airDefenceTowerPrefab;
    public GameObject laserTowerPrefab;

    private GameObject turretToBuild;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one buildmanager in scene");
        }
        instance = this;
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
    public void SetTowerToBuild(TowerType towerType)
    {
        switch (towerType)
        {
            case TowerType.Cannon:
                turretToBuild = cannonTowerPrefab;
                break;
            case TowerType.Mortar:
                turretToBuild = mortarTowerPrefab;
                break;
            case TowerType.Laser:
                turretToBuild = airDefenceTowerPrefab;
                break;
            case TowerType.AirDefence:
                turretToBuild = laserTowerPrefab;
                break;
            default:
                turretToBuild = null;
                break;
        }
    }
}
