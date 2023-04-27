using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cannon : Tower
{
    //public float turretRange = 10f;
    //public LayerMask enemyLayer;
    //public List<GameObject> enemiesInRange;
    //public GameObject currentTarget;
    //public GameObject projectilePrefab;
    //public Transform firePoint;
    //public Transform horizontalRotator;
    //public Transform verticalRotator;
    //public float horizontalRotationSpeed = 10f;
    //public float verticalRotationSpeed = 10f;
    //public float fireRate = 1f;
    //public float gizmoLineLength = 10f;
    //private float lastFireTime;
    //public float minimumVerticalRotation;
    //public float maxVerticalRotation;
    //public float verticalPivotOffset;
    //public float detectionInterval = 0.5f;
    //void Start()
    //{

    //    enemiesInRange = new List<GameObject>();
    //    InvokeRepeating(nameof(DetectEnemiesInRange), detectionInterval, detectionInterval);
    //}
    //void Update()
    //{
    //    SelectTarget();
    //    if (currentTarget != null)
    //    {
    //        RotateTowardsTarget();
    //        ShootAtTarget();
    //    }
    //}

    //private void RotateTowardsTarget()
    //{
    //    Vector3 direction = currentTarget.transform.position - horizontalRotator.position;

    //    // Horizontal rotation (yaw)
    //    Vector3 horizontalDirection = new Vector3(direction.x, 0, direction.z);
    //    Quaternion horizontalTargetRotation = Quaternion.LookRotation(horizontalDirection);
    //    horizontalRotator.rotation = Quaternion.Slerp(horizontalRotator.rotation, horizontalTargetRotation, horizontalRotationSpeed * Time.deltaTime);

    //    // Vertical rotation (pitch)
    //    Vector3 localDirection = transform.InverseTransformDirection(direction) + new Vector3(0, verticalPivotOffset, 0);
    //    float angle = -Mathf.Atan2(localDirection.y, localDirection.z) * Mathf.Rad2Deg;
    //    angle = Mathf.Clamp(angle, minimumVerticalRotation, maxVerticalRotation);
    //    Quaternion verticalTargetRotation = Quaternion.Euler(angle, verticalRotator.localEulerAngles.y, verticalRotator.localEulerAngles.z);
    //    verticalRotator.localRotation = Quaternion.Slerp(verticalRotator.localRotation, verticalTargetRotation, verticalRotationSpeed * Time.deltaTime);
    //}
    //private void SelectTarget()
    //{
    //    if (enemiesInRange.Count<1 || enemiesInRange==null)
    //    {
    //        currentTarget = null;
    //        return;
    //    }
    //    // Example criteria: Select the closest enemy
    //    float closestDistance = Mathf.Infinity;

    //    foreach (GameObject enemy in enemiesInRange)
    //    {
    //        if (enemy == null)
    //        {
    //            continue;
    //        }

    //        float distance = Vector3.Distance(transform.position, enemy.transform.position);
    //        if (distance < closestDistance)
    //        {
    //            closestDistance = distance;
    //            currentTarget = enemy;
    //        }
    //    }

    //    // The turret can now use 'currentTarget' to aim and shoot
    //}
    //private void ShootAtTarget()
    //{
    //    if (Time.time > lastFireTime + 1f / fireRate)
    //    {
    //        GameObject projectileObject = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    //        projectileObject.GetComponent<CanonProjectile>().InitializeProjectile();
    //        lastFireTime = Time.time;
    //    }
    //}

    ////private void OnTriggerEnter(Collider other)
    ////{
    ////    if (((1 << other.gameObject.layer) & enemyLayer) != 0)
    ////    {
    ////        enemiesInRange.Add(other.gameObject);
    ////    }
    ////}

    ////private void OnTriggerExit(Collider other)
    ////{
    ////    if (((1 << other.gameObject.layer) & enemyLayer) != 0)
    ////    {
    ////        enemiesInRange.Remove(other.gameObject);
    ////    }
    ////}
    //private void DetectEnemiesInRange()
    //{
    //    Debug.Log("Detecting....");
    //    enemiesInRange.Clear();
    //    Collider[] collidersInRange = Physics.OverlapSphere(transform.position, turretRange, enemyLayer);
    //    foreach (Collider collider in collidersInRange)
    //    {
    //        if(collider.gameObject.tag == "Enemy")
    //        {
    //            enemiesInRange.Add(collider.gameObject);
    //            Debug.Log("Enemy in range");
    //        }
            
    //    }  
    //}
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawLine(firePoint.position, firePoint.position + firePoint.forward * gizmoLineLength);
    //    Gizmos.DrawWireSphere(transform.position, turretRange);
    //}
}