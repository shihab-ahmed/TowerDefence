using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortar : Tower
{
    //public float turretRange = 10f;
    //public float turretInnerRange=3f;
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
    //    currentTarget=GetTarget();
    //    if (currentTarget != null)
    //    {
    //        RotateTowardsTarget();
    //        ShootAtTarget();
    //    }
    //}

    //private void RotateTowardsTarget()
    //{
    //    Vector3 direction = currentTarget.transform.position - horizontalRotator.position;

    //    Vector3 horizontalDirection = new Vector3(direction.x, 0, direction.z);
    //    Quaternion horizontalTargetRotation = Quaternion.LookRotation(horizontalDirection);
    //    horizontalRotator.rotation = Quaternion.Slerp(horizontalRotator.rotation, horizontalTargetRotation, horizontalRotationSpeed * Time.deltaTime);
    //    verticalRotator.localEulerAngles = new Vector3(maxVerticalRotation, 0, 0);
    //}
    //private GameObject GetTarget()
    //{
    //    GameObject target  = null;
    //    if (enemiesInRange.Count < 1)
    //    {
    //        return target;
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
    //        if (distance < turretInnerRange) continue;
    //        if (distance < closestDistance)
    //        {
    //            closestDistance = distance;
    //            target = enemy;
    //        }
    //    }
    //    return target;
    //    // The turret can now use 'currentTarget' to aim and shoot
    //}
    //private void ShootAtTarget()
    //{
    //    if (Time.time > lastFireTime + 1f / fireRate)
    //    {
    //        float shotToAngle = 360 - verticalRotator.localEulerAngles.x;
    //        GameObject projectileObject = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    //        projectileObject.GetComponent<MortarProjectile>().InitializeProjectile(currentTarget.transform.position, shotToAngle);
    //        //if (turretType == TurretType.Cannon)
    //        //{w

    //        //}
    //        //else if (turretType == TurretType.Mortar)
    //        //{
    //        //    float mortarFiringAngle = 45f;
    //        //    ProjectileMortar mortarProjectile = projectileObject.GetComponent<ProjectileMortar>();
    //        //    mortarProjectile.SetTargetPosition(currentTarget.transform.position);

    //        //    //float firingAngle = Mathf.Deg2Rad * mortarFiringAngle;
    //        //    //float gravity = Physics.gravity.magnitude;
    //        //    //float targetDistance = Vector3.Distance(firePoint.position, currentTarget.transform.position);

    //        //    //float projectileVelocity = Mathf.Sqrt(targetDistance * gravity / Mathf.Sin(2 * firingAngle));

    //        //    //Vector3 launchDirection = (currentTarget.transform.position - firePoint.position).normalized;
    //        //    //Vector3 launchVelocity = new Vector3(launchDirection.x, Mathf.Tan(firingAngle), launchDirection.z) * projectileVelocity;

    //        //    //Rigidbody rb = projectileObject.GetComponent<Rigidbody>();
    //        //    //rb.velocity = launchVelocity;

    //        //    //Vector3 launchDirection = (currentTarget.transform.position - firePoint.position);
    //        //    //launchDirection.y = 0f; // Ignore height difference for horizontal distance calculation
    //        //    //float horizontalDistance = launchDirection.magnitude;
    //        //    //float verticalDistance = currentTarget.transform.position.y - firePoint.position.y;
    //        //    //float firingAngle = Mathf.Deg2Rad * mortarFiringAngle;
    //        //    //float gravity = Physics.gravity.magnitude;

    //        //    //// Calculate the velocity required to reach the target with the given angle
    //        //    //float velocity = Mathf.Sqrt((gravity * horizontalDistance * horizontalDistance) / (2 * (horizontalDistance * Mathf.Tan(firingAngle) - verticalDistance)));

    //        //    //// Calculate the launch velocities
    //        //    //Vector3 launchVelocity = launchDirection.normalized * velocity * Mathf.Cos(firingAngle);
    //        //    //launchVelocity.y = velocity * Mathf.Sin(firingAngle);

    //        //    //Rigidbody rb = projectileObject.GetComponent<Rigidbody>();
    //        //    //rb.velocity = launchVelocity;

    //        //    //Vector3 launchDirection = (currentTarget.transform.position - firePoint.position);
    //        //    //float gravity = Physics.gravity.magnitude;

    //        //    //// Calculate the time for the projectile to reach the target
    //        //    //float projectileTime = Mathf.Sqrt((2 * launchDirection.y) / gravity) + Mathf.Sqrt((2 * (currentTarget.transform.position.y - firePoint.position.y)) / gravity);

    //        //    //// Calculate the required velocity in the XZ plane
    //        //    //Vector3 horizontalVelocity = new Vector3(launchDirection.x, 0, launchDirection.z) / projectileTime;

    //        //    //// Calculate the required velocity in the Y direction
    //        //    //float verticalVelocity = launchDirection.y / projectileTime + 0.5f * gravity * projectileTime;

    //        //    //Vector3 launchVelocity = new Vector3(horizontalVelocity.x, verticalVelocity, horizontalVelocity.z);

    //        //    //Rigidbody rb = projectileObject.GetComponent<Rigidbody>();
    //        //    //rb.velocity = launchVelocity;
    //        //}
    //        //else if (turretType == TurretType.AirDefence)
    //        //{
    //        //    //projectileObject.GetComponent<ProjectileMissile>().InitializeProjectile(this.gameObject, currentTarget);
    //        //}

    //        //projectile.GetComponent<Rigidbody>().velocity = (currentTarget.transform.position - firePoint.position).normalized * 10;
    //        lastFireTime = Time.time;
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (((1 << other.gameObject.layer) & enemyLayer) != 0)
    //    {
    //        enemiesInRange.Add(other.gameObject);
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (((1 << other.gameObject.layer) & enemyLayer) != 0)
    //    {
    //        enemiesInRange.Remove(other.gameObject);
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
    //    Gizmos.color = Color.green;
    //    Gizmos.DrawWireSphere(transform.position, turretInnerRange);
    //}
}
