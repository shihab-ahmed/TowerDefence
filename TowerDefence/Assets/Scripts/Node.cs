using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Node : MonoBehaviour
{
    public GameObject nodePreviewObject;
    public GameObject placementObject;
    public Color defaultColor;
    public Color highlightOccupiedColor;
    public Color highlightUnOccupiedColor;
    [SerializeField]private GameObject turret;
    public int nodeHeight;
    private BuildManager buildManager;
    private void Start()
    {
        buildManager = GameManager.Instance.buildManager;
    }
    private void OnMouseEnter()
    {
        //if (nodePreviewObject == null) return;
        //if (EventSystem.current.IsPointerOverGameObject()) return;
        //if (!buildManager.CanBuild)return;

        //if (turret != null)
        //{
        //    nodePreviewObject.GetComponent<MeshRenderer>().material.color = highlightOccupiedColor;
        //    Debug.Log("Can't build there! - TODO: Display on screen.");
        //}
        //turret = buildManager.BuildTurretOn(this);
    }
    private void OnMouseExit()
    {
        if (nodePreviewObject != null)
        {
            nodePreviewObject.GetComponent<MeshRenderer>().material.color = defaultColor;
        }
    }
    private void OnMouseDown()
    {

        if (nodePreviewObject == null) return;
        if (EventSystem.current.IsPointerOverGameObject()) return;
        if (!buildManager.CanBuild) return;

        if (turret != null)
        {
            nodePreviewObject.GetComponent<MeshRenderer>().material.color = highlightOccupiedColor;
            Debug.Log("Can't build there! - TODO: Display on screen.");
        }
        turret = buildManager.BuildTurretOn(this);

        //if (EventSystem.current.IsPointerOverGameObject()) return;
        //if (turret != null)
        //{
        //    Debug.Log("There is a object here already. To do modification");
        //    return;
        //}
        //else
        //{
        //    //GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        //    //if(turretToBuild == null)
        //    //{
        //    //    Debug.Log("Turret to build is null");
        //    //    return;
        //    //}
        //    //turret = Instantiate(turretToBuild, placementObject.transform.position, placementObject.transform.rotation);
        //}
    }
}
