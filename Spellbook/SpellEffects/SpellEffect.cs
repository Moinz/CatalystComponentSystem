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
*   	Base Class for Spell Effects
*   </summary>
*/

public class SpellEffect : MonoBehaviour, IEffectComponent
{
    public void Effect(Vector3 position)
    {
        Debug.Log("On Hit Spell Effect");
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }
}
