using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;

    public float minX = -50f;
    public float maxX = 50f;
    public float minZ = -50f;
    public float maxZ = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * panSpeed * Time.deltaTime,Space.World);
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        //}


        // Move the camera with the arrow keys or WASD
        // Move the camera with the arrow keys or WASD
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            moveDirection += Vector3.ProjectOnPlane(transform.forward, Vector3.up);
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            moveDirection -= Vector3.ProjectOnPlane(transform.forward, Vector3.up);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            moveDirection -= Vector3.ProjectOnPlane(transform.right, Vector3.up);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            moveDirection += Vector3.ProjectOnPlane(transform.right, Vector3.up);

        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;

        // Clamp the camera position within the specified boundaries
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedZ = Mathf.Clamp(transform.position.z, minZ, maxZ);
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);

        // Zoom in and out using the mouse scroll wheel
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        float newCameraY = transform.position.y - scrollInput * scrollSpeed;
        newCameraY = Mathf.Clamp(newCameraY, minY, maxY);
        transform.position = new Vector3(transform.position.x, newCameraY, transform.position.z);
    }
}
