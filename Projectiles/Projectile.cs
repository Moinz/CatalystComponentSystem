using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrimsonCouncil.Moin.Catalyst;
/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Base Projectile Script
*   </summary>
*/
[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class Projectile : MonoBehaviour, IProjectile
{
    protected Rigidbody2D rb2D;
    public float nativeForce;
    [SerializeField]
    public EffectComponent onHitEffect;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    public virtual void Launch(Vector2 direction)
    {
        rb2D.velocity = direction * nativeForce;
        StartCoroutine(DespawnTimer(5));
    }

    public virtual void Launch(Vector2 direction, float seconds)
    {
        rb2D.velocity = direction * nativeForce;
        StartCoroutine(DespawnTimer(seconds));
    }

    public virtual IEnumerator DespawnTimer (float seconds)
    {
        yield return new WaitForSeconds(seconds);

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onHitEffect = GetComponentInChildren<EffectComponent>();
        onHitEffect.StartCoroutine("Effect", collision.transform.position);
    }
}
