using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    [SerializeField] private GameObject turretToBuildPrefab;
    [SerializeField] private Node selectedNode;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }
    public bool CanBuild { get { return turretToBuildPrefab != null; } }
    public void SetTurretToBuild(GameObject turretToBuildPrefab)
    {
        this.turretToBuildPrefab = turretToBuildPrefab;
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuildPrefab;
    }
    public GameObject BuildTurretOn(Node node)
    {
        GameObject turret = (GameObject)Instantiate(turretToBuildPrefab, node.transform.position + Vector3.up * 0.5f, Quaternion.identity);
        Tower tower = turret.GetComponent<Tower>();
        if(tower == null)
        {
            Debug.LogError("tower component not found");
            return null;
        }
        Player.Instance.CurrentMoney -= tower.GetBuildCost();
        return turret;
    }
}
