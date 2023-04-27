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
    public GameObject turret;
    public int nodeHeight;
    private void OnMouseEnter()
    {
        if (nodePreviewObject == null) return;
        if(turret != null)
        {
            nodePreviewObject.GetComponent<MeshRenderer>().material.color= highlightOccupiedColor;
        }
        else
        {
            nodePreviewObject.GetComponent<MeshRenderer>().material.color = highlightUnOccupiedColor;
        }
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
        if (EventSystem.current.IsPointerOverGameObject()) return;
        Debug.Log("Mouse down");
        if (turret != null)
        {
            Debug.Log("There is a object here already");
            return;
        }
        else
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            if(turretToBuild == null)
            {
                Debug.Log("Turret to build is null");
                return;
            }
            turret = Instantiate(turretToBuild, placementObject.transform.position, placementObject.transform.rotation);
        }
    }
}
