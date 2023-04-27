using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortarProjectile : Projectile
{
    public override void InitializeProjectile(Tower instigator, Enemy target, ProjectileDamage projectileDamage)
    {
        base.InitializeProjectile(instigator, target , projectileDamage);
        FireProjectile();
    }
    //public float explosionRadius = 5f;
    //public float damage = 50f;
    //public GameObject explosionEffectPrefab;

    //public Vector3 targetPosition;
    //public float barrelAngle;
    //public void InitializeProjectile(Vector3 targetPosition, float barrelAngle)
    //{
    //    this.targetPosition = targetPosition;
    //    this.barrelAngle = barrelAngle;
    //    Fire();
    //}
    //private void Fire()
    //{
    //    float angleInRadians = Mathf.Deg2Rad * barrelAngle;
    //    float cosAngle = Mathf.Cos(angleInRadians);
    //    float sinAngle = Mathf.Sin(angleInRadians);

    //    Vector3 displacement = targetPosition - transform.position;
    //    float dx = new Vector3(displacement.x, 0, displacement.z).magnitude;
    //    float dy = displacement.y;

    //    float tanAngle = Mathf.Tan(angleInRadians);
    //    //Debug.Log("tan: " + tanAngle + "angleInRadians "+ angleInRadians);
    //    //Debug.Log("dx: " + dx + "dy " + dy);
    //    float gravity = Physics.gravity.magnitude;

    //    float Vx = Mathf.Sqrt((gravity * dx * dx) / (2 * (dx * tanAngle - dy)));
    //    float Vy = Vx * tanAngle;


    //    //Debug.Log("vx: " + Vx + " vy:" + Vy);
    //    Vector3 launchVelocity = new Vector3(displacement.x, 0, displacement.z).normalized * Vx;
    //    launchVelocity.y = Vy;

    //    //Debug.Log(launchVelocity);

    //    Rigidbody rb = GetComponent<Rigidbody>();
    //    rb.velocity = launchVelocity;
    //}
    //private void OnTriggerEnter(Collider collision)
    //{
    //    // Assuming all enemies have a tag called "Enemy"
    //    Explode();
    //    Destroy(gameObject);
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


    //}
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(transform.position, explosionRadius);
    //}
    protected override void FireProjectile()
    {
        float angleInRadians = Mathf.Deg2Rad * instigator.GetFireAngle();
        float cosAngle = Mathf.Cos(angleInRadians);
        float sinAngle = Mathf.Sin(angleInRadians);

        Vector3 displacement = target.transform.position - transform.position;
        float dx = new Vector3(displacement.x, 0, displacement.z).magnitude;
        float dy = displacement.y;

        float tanAngle = Mathf.Tan(angleInRadians);
        //Debug.Log("tan: " + tanAngle + "angleInRadians "+ angleInRadians);
        //Debug.Log("dx: " + dx + "dy " + dy);
        float gravity = Physics.gravity.magnitude;

        float Vx = Mathf.Sqrt((gravity * dx * dx) / (2 * (dx * tanAngle - dy)));
        float Vy = Vx * tanAngle;


        //Debug.Log("vx: " + Vx + " vy:" + Vy);
        Vector3 launchVelocity = new Vector3(displacement.x, 0, displacement.z).normalized * Vx;
        launchVelocity.y = Vy;

        //Debug.Log(launchVelocity);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = launchVelocity;
    }
}
