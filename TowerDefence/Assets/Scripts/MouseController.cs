using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private RaycastHit[] hits;
    // Update is called once per frame
    void Update()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //// Perform a raycast from the camera through the mouse pointer's position
        //hits = Physics.RaycastAll(ray, Mathf.Infinity);

        //// Sort the hits by distance
        //System.Array.Sort(hits, (hit1, hit2) => hit1.distance.CompareTo(hit2.distance));

        //// Iterate through the hits
        //foreach (RaycastHit hit in hits)
        //{
        //    if (hit.collider.gameObject.tag == "Node")
        //    {
        //        Debug.Log("Clicked on: " + hit.collider.gameObject.name);
        //        Node node = hit.collider.gameObject.GetComponent<Node>();
        //        //if (node != null)
        //        //{
        //        //    node.on
        //        //}
        //    }
        //}

        //if (Input.GetMouseButtonDown(0))
        //{
            
        //    //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    //// Perform a raycast from the camera through the mouse pointer's position
        //    //hits = Physics.RaycastAll(ray, Mathf.Infinity);

        //    //// Sort the hits by distance
        //    //System.Array.Sort(hits, (hit1, hit2) => hit1.distance.CompareTo(hit2.distance));

        //    //// Iterate through the hits
        //    //foreach (RaycastHit hit in hits)
        //    //{
                

        //    //    if(hit.collider.gameObject.tag=="Node")
        //    //    {
        //    //        Debug.Log("Clicked on: " + hit.collider.gameObject.name);
        //    //    }
        //    //}
        //}
    }
}
