using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Projectile that moves in Sine
*   </summary>
*/

public class ProjectileBoomerang : Projectile 
{
    public override void Launch(Vector2 direction)
    {
        StartCoroutine(Timer(direction));
        StartCoroutine(DespawnTimer(5));
    }

    public override void Launch(Vector2 direction, float seconds)
    {
        rb2D.velocity = direction * nativeForce;
        StartCoroutine(DespawnTimer(seconds));
    }

    public override IEnumerator DespawnTimer(float seconds)
    {
        return base.DespawnTimer(seconds);
    }

    public IEnumerator Timer (Vector2 direction)
    {
        rb2D.velocity = direction * nativeForce;
        yield return new WaitForSeconds(2.5f);
        rb2D.velocity = -rb2D.velocity;
    }
}
