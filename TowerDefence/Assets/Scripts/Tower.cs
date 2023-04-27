using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetMode
{
    Ground,
    Air,
    Both,
    Support
}
public abstract class Tower : MonoBehaviour
{
    [SerializeField] protected bool isUnlocked;
    [SerializeField] protected float defaultRange;
    [SerializeField] protected float currentRange;
    [SerializeField] protected float turretInnerRange;
    [SerializeField] protected LayerMask enemyLayer;
    [SerializeField] protected List<GameObject> enemiesInRange;
    [SerializeField] protected GameObject currentTarget;
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected Transform firePoint;
    [SerializeField] protected Transform horizontalRotator;
    [SerializeField] protected Transform verticalRotator;
    [SerializeField] protected float horizontalRotationSpeed;
    [SerializeField] protected float verticalRotationSpeed;
    [SerializeField] protected float fireRate;
    [SerializeField] protected float gizmoLineLength;
    [SerializeField] protected float lastFireTime;
    [SerializeField] protected float minimumVerticalRotation;
    [SerializeField] protected float maxVerticalRotation;
    [SerializeField] protected float verticalPivotOffset;
    [SerializeField] protected float detectionInterval;
    [SerializeField] protected bool hasInnerSafeCircle;
    [SerializeField] protected int buildCost;
    [SerializeField] protected Sprite towerSprite;
    [SerializeField] protected TargetMode targetMode;
    [SerializeField] protected Transform shotToTarget;
    [SerializeField] protected ProjectileDamage projectileDamage;
    private void Start()
    {
        currentRange = defaultRange;
        enemiesInRange = new List<GameObject>();
        InvokeRepeating(nameof(DetectEnemiesInRange), detectionInterval, detectionInterval);
    }
    private void Update()
    {
        GameObject target = GetTarget();
        
        if (target != null)
        {
            if(target!=currentTarget)
            {
                currentTarget = target;
                Enemy enemy = currentTarget.GetComponent<Enemy>();
                shotToTarget = enemy.GetShotToTarget();
            }
            RotateTowardsTarget();
            ShootAtTarget();
        }
    }
    protected virtual void RotateTowardsTarget()
    {
        
        Vector3 direction = shotToTarget.position - horizontalRotator.position;

        if(horizontalRotationSpeed > 0)
        {
            // Horizontal rotation (yaw)
            Vector3 horizontalDirection = new Vector3(direction.x, 0, direction.z);
            Quaternion horizontalTargetRotation = Quaternion.LookRotation(horizontalDirection);
            horizontalRotator.rotation = Quaternion.Slerp(horizontalRotator.rotation, horizontalTargetRotation, horizontalRotationSpeed * Time.deltaTime);
        }
        if(verticalRotationSpeed > 0)
        {
            // Vertical rotation (pitch)
            Vector3 localDirection = transform.InverseTransformDirection(direction) + new Vector3(0, verticalPivotOffset, 0);
            float angle = -Mathf.Atan2(localDirection.y, localDirection.z) * Mathf.Rad2Deg;
            angle = Mathf.Clamp(angle, minimumVerticalRotation, maxVerticalRotation);
            Quaternion verticalTargetRotation = Quaternion.Euler(angle, verticalRotator.localEulerAngles.y, verticalRotator.localEulerAngles.z);
            verticalRotator.localRotation = Quaternion.Slerp(verticalRotator.localRotation, verticalTargetRotation, verticalRotationSpeed * Time.deltaTime);
        }

    }
    private void ShootAtTarget()
    {
        if (Time.time > lastFireTime + 1f / fireRate)
        {
            Debug.Log("shot");
            GameObject projectileObject = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            if (projectileObject != null && projectileObject.GetComponent<Projectile>() != null)
            {
                projectileObject.GetComponent<Projectile>().InitializeProjectile(this, currentTarget.GetComponent<Enemy>(),projectileDamage);
            }
            else
            {
                Debug.LogError("Projectile script not found");
            }
            lastFireTime = Time.time;
        }
    }
    protected GameObject GetTarget()
    {
        //Implement priotize target system later

        GameObject target = null;
        float closestDistance = defaultRange;
        if (enemiesInRange.Count < 1)
        {
            //No enemy in range
            return target;
        }

        foreach (GameObject enemy in enemiesInRange)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < turretInnerRange && hasInnerSafeCircle) continue;
            if (distance < closestDistance)
            {
                closestDistance = distance;
                target = enemy;
            }
        }
        return target;
    }
    protected virtual void DetectEnemiesInRange()
    {
        if (targetMode == TargetMode.Support) return;
        //Debug.Log("Detecting....");
        enemiesInRange.Clear();
        Collider[] collidersInRange = Physics.OverlapSphere(transform.position, defaultRange, enemyLayer);
        foreach (Collider collider in collidersInRange)
        {
            if (collider.gameObject.tag == "Enemy")
            {
                Enemy enemy = collider.gameObject.GetComponent<Enemy>();
                if (enemy == null) continue;

                if(targetMode == TargetMode.Ground && enemy.GetMovementType() == MovementType.walking)
                {
                    enemiesInRange.Add(collider.gameObject);
                }
                else if (targetMode == TargetMode.Air && enemy.GetMovementType() == MovementType.flying)
                {
                    enemiesInRange.Add(collider.gameObject);
                }
                else if (targetMode == TargetMode.Both)
                {
                    enemiesInRange.Add(collider.gameObject);
                }
            }

        }
    }
    //For mortar only
    public float GetFireAngle()
    {
        return Mathf.Abs(360-verticalRotator.localEulerAngles.x);
    }
    private void OnDrawGizmos()
    {
        //Debug.Log("xx");
        Gizmos.color = Color.red;
        Gizmos.DrawLine(firePoint.position, firePoint.position + firePoint.forward * gizmoLineLength);
        Gizmos.DrawWireSphere(transform.position, defaultRange);
        if(hasInnerSafeCircle)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, turretInnerRange);
        }
    }
    public int GetBuildCost()
    {
        return buildCost;
    }
    public Sprite GetTowerSprite()
    {
        return towerSprite;
    }
}
