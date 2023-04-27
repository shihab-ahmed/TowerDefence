using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int wayPointIndex = 0;
    public float MaxHealth = 10;
    public float CurrentHealt;
    // Start is called before the first frame update
    void Start()
    {
        //CurrentHealt = MaxHealth;
        //target = Waypoints.points[wayPointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }
    private void GetNextWaypoint()
    {
        //wayPointIndex++;
        //if (wayPointIndex < Waypoints.points.Length)
        //{
        //    target = Waypoints.points[wayPointIndex];
        //}
        //else
        //{
        //    //Debug.Log("Destination reached");
        //    Destroy(gameObject);
        //}
    }
    public void ApplyDamage(float damage)
    {
        CurrentHealt -= damage;
        if(CurrentHealt <= 0)
        {
            Debug.Log("Enemy died");
            Destroy(gameObject);
        }
    }
}
