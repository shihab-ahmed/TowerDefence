using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AirTurret : Tower
{
    //public float turretRange = 10f;
    //public LayerMask enemyLayer;
    //public List<GameObject> enemiesInRange;
    //public GameObject currentTarget;
    //public GameObject projectilePrefab;
    //public Transform firePoint;
    //public Transform horizontalRotator;
    //public float horizontalRotationSpeed = 10f;
    //public float verticalRotationSpeed = 10f;
    //public float fireRate = 1f;
    //public float gizmoLineLength = 10f;
    //private float lastFireTime;
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

    //}
    //private void SelectTarget()
    //{
    //    if (enemiesInRange.Count < 1)
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
    //}
    //private void ShootAtTarget()
    //{
    //    if (Time.time > lastFireTime + 1f / fireRate)
    //    {
    //        GameObject projectileObject = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    //        projectileObject.GetComponent<MissileProjectile>().InitializeProjectile(this.gameObject,currentTarget);
    //        lastFireTime = Time.time;
    //    }
    //}
    //private void DetectEnemiesInRange()
    //{
    //    Debug.Log("Detecting....");
    //    enemiesInRange.Clear();
    //    Collider[] collidersInRange = Physics.OverlapSphere(transform.position, turretRange, enemyLayer);
    //    foreach (Collider collider in collidersInRange)
    //    {
    //        if (collider.gameObject.tag == "Enemy")
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