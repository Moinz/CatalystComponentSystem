using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Base class for all Melee Effects
*   </summary>
*/

public class MeleeEffect : MonoBehaviour, IEffectComponent
{
    public void Effect(Vector3 position)
    {
        Debug.Log("On Hit Melee Effect");
    }

    public void Initialize()
    {
        // Implement me baby;
        throw new NotImplementedException();
    }
}
