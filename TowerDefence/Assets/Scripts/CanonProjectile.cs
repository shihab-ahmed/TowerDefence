using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonProjectile : Projectile
{
    [SerializeField] protected float speed;
    public override void InitializeProjectile(Tower instigator, Enemy target , ProjectileDamage projectileDamage)
    {
        base.InitializeProjectile(instigator, target, projectileDamage);
        FireProjectile();
    }
    protected override void FireProjectile()
    {
        rb.velocity = transform.forward * speed;
    }
    //public float speed = 20f;
    //public float damage = 5f;
    //public float lifetime = 5f;
    //public Rigidbody rb;
    //public GameObject ImpactPrefab;
    //public void InitializeProjectile()
    //{
    //    Fire();
    //}
    //private void Fire()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    rb.velocity = transform.forward * speed;
    //    Destroy(gameObject, lifetime);
    //}

    //void OnTriggerEnter(Collider collision)
    //{
    //    //Debug.Log("Hit something");
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        // Apply damage to the enemy
    //        // Replace 'EnemyHealth' with the actual script handling the enemy's health
    //        //EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
    //        //if (enemyHealth != null)
    //        //{
    //        //    enemyHealth.TakeDamage(damage);
    //        //}

    //        //GameObject effect = Instantiate(ImpactPrefab,transform.position,transform.rotation);
    //        //Destroy(effect,2f);
    //        EnemyPlayer enemyPlayer = collision.gameObject.GetComponent<EnemyPlayer>();
    //        if (enemyPlayer != null)
    //        {
    //            enemyPlayer.ApplyDamage(damage);
    //        }
    //        Debug.Log("Hit enemy");
    //    }

    //    // Destroy the bullet
    //    Destroy(gameObject);
    //}
}
