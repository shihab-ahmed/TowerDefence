using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Element
{
    normal,
    fire,
    ice
}
public enum MovementType
{
    walking,
    flying
}
public enum MonsterRank
{
    Common,
    Rare,
    Epic,
    Divine,
    Legend,
    Elder,
    Chaos,
    God
}
public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected string name;
    [SerializeField] protected int level;
    [SerializeField] protected float maxHealth;
    private float currentHealth;
    [SerializeField] protected float defaultMovementSpeed;
    private float currentMovementSpeed;
    [SerializeField] protected float maxArmour;
    private float currentArmour;
    [SerializeField] protected float maxShield;
    private float currentShield;
    [SerializeField] protected float dropGold;
    [SerializeField] protected float dropExperience;
    [SerializeField] protected Element element;
    [SerializeField] protected MovementType movementType;
    [SerializeField] protected MonsterRank monsterRank;
    [SerializeField] protected Element inflictedElement;
    [SerializeField] protected Transform shotToTarget;
    private Transform moveToWaypoint;
    private int wayPointIndex;
    [SerializeField] protected float distanceFromGround;
    [SerializeField] protected bool isDestinationReached;
    void Start()
    {
        currentHealth = maxHealth;
        currentArmour = maxArmour;
        currentShield = maxShield;
        currentMovementSpeed = defaultMovementSpeed;
        wayPointIndex = 0;
        transform.localPosition = new Vector3(transform.localPosition.x,distanceFromGround,transform.localPosition.z);
        moveToWaypoint = GameManager.Instance.waypoints.points[wayPointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (isDestinationReached) return;
        Vector3 adjustedMoveToTarget = new Vector3(moveToWaypoint.position.x, distanceFromGround, moveToWaypoint.position.z);
        Vector3 direction = adjustedMoveToTarget - transform.position;
        transform.Translate(direction.normalized * currentMovementSpeed * Time.deltaTime, Space.World);
        float distance = Vector3.Distance(transform.position, adjustedMoveToTarget);
        //Debug.Log(distance);
        if (distance <= 0.2f)
        {
            GetNextWaypoint();
        }
    }
    private void GetNextWaypoint()
    {
        wayPointIndex++;
        if (wayPointIndex < GameManager.Instance.waypoints.points.Length)
        {
            moveToWaypoint = GameManager.Instance.waypoints.points[wayPointIndex];
        }
        else
        {
            Debug.Log("Destination reached");
            ApplyDamageToPlayer();
            //Destroy(gameObject);
        }
    }
    public virtual void ApplyDamage(ProjectileDamage projectileDamage)
    {
        currentHealth -= projectileDamage.damage;
        if (currentHealth <= 0)
        {
            Debug.Log("Enemy died");
            Destroy(gameObject);
        }
    }
    protected virtual void ApplyDamageToPlayer()
    {
        Debug.Log("ApplyDamageToPlayer");
    }
    public Transform GetShotToTarget()
    {
        return shotToTarget;
    }
    public MovementType GetMovementType()
    {
        return movementType;
    }
}
