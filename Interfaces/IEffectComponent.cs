using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Interface for on hit effects
*   </summary>
*/

public interface IEffectComponent
{
    void Effect(Vector3 position);
    void Initialize();
}
