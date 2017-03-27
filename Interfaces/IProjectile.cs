using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Interface for Projectile
*   </summary>
*/

public interface IProjectile 
{
    void Launch(Vector2 direction);
    void Launch(Vector2 direction, float seconds);
    IEnumerator DespawnTimer(float seconds);
}
