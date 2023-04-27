using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileProjectile : Projectile
{
    [SerializeField] protected float speed;
    //public float speed = 10f;
    [SerializeField] private float rotationSpeed;
    //public float explosionRadius = 1f;
    //public float damage = 50f;
    //public GameObject explosionEffectPrefab;
    //public GameObject instigator;
    //private Transform target;
    //public Rigidbody rb;

    //public void InitializeProjectile(GameObject instigator, GameObject target)
    //{
    //    rb = GetComponent<Rigidbody>();
    //    this.instigator = instigator;
    //    this.target = target.transform;
    //}
    void Update()
    {
        FireProjectile();
    }

    //private void OnTriggerEnter(Collider other)
    //{

    //    // Assuming all enemies have a tag called "Enemy"
    //    if (other.CompareTag("Enemy"))
    //    {
    //        Debug.Log("Hit enemy");
    //        Explode();
    //    }
    //    else
    //    {
    //        Debug.Log(other.name);
    //    }
    //}

    //private void Explode()
    //{
    //    //// Instantiate explosion effect
    //    //if (explosionEffectPrefab != null)
    //    //{
    //    //    Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);
    //    //}

    //    // Damage enemies within explosion radius
    //    Collider[] hitColliders = Physics.OverlapSphere(transform.position, explosionRadius);
    //    foreach (Collider hitCollider in hitColliders)
    //    {
    //        if (hitCollider.CompareTag("Enemy"))
    //        {
    //            // Apply damage to the enemy here
    //            // You can use SendMessage, GetComponent, or any other method to apply damage to the enemy
    //            EnemyPlayer enemyPlayer = hitCollider.gameObject.GetComponent<EnemyPlayer>();
    //            if (enemyPlayer != null)
    //            {
    //                enemyPlayer.ApplyDamage(damage);
    //            }
    //        }
    //    }

    //    Destroy(gameObject);
    //}
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(transform.position, explosionRadius);
    //}
    protected override void FireProjectile()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 directionToTarget = (target.transform.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        rb.velocity = transform.forward * speed;
    }
}
