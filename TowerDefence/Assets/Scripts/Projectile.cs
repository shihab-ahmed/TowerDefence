using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [SerializeField] protected float damage;
    [SerializeField] protected float lifetime;
    [SerializeField] protected float explosionRadius;
    [SerializeField] protected Rigidbody rb;
    [SerializeField] protected GameObject explosionEffectPrefab;
    [SerializeField] protected float effectLifetime;
    [SerializeField] protected Enemy target;
    [SerializeField] protected Tower instigator;
    [SerializeField] protected ProjectileDamage projectileDamage;
    public virtual void InitializeProjectile(Tower instigator, Enemy target , ProjectileDamage projectileDamage)
    {
        this.projectileDamage = projectileDamage;
        rb = GetComponent<Rigidbody>();
        if(rb == null)
        {
            Debug.LogError("Rigidbody not found in this projectile");
            Destroy(gameObject);
        }
        this.instigator = instigator;
        this.target = target;
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter(Collider other)
    {
        // Assuming all enemies have a tag called "Enemy"
        if(explosionRadius > 0)
        {
            Explode();
        }
        else
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Try applying damage to enemy");
            }
        }
        Destroy(gameObject);
    }
    protected virtual void Explode()
    {
        //// Instantiate explosion effect
        if (explosionEffectPrefab != null)
        {
            GameObject effect = Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);
            Destroy(effect,effectLifetime);
        }
        // Damage enemies within explosion radius
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Enemy"))
            {
                // Apply damage to the enemy here
                // You can use SendMessage, GetComponent, or any other method to apply damage to the enemy
                Enemy enemy = hitCollider.gameObject.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.ApplyDamage(projectileDamage);
                }
                Debug.Log("Try applying damage to exploded enemy");
            }
        }

    }
    protected abstract void FireProjectile();
    private void OnDrawGizmos()
    {
        if(explosionRadius > 0)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, explosionRadius);
        }
    }
}
