using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Ultimate Inferno Spell
*   </summary>
*/

public class UltimateComponentInferno : UltimateComponent
{
    public override void Ultimate(Vector3 position)
    {
        Debug.Log("Ultimate Spell: " + position.ToString());
    }

    public override string ToString()
    {
        return "Ultimate Inferno";
    }
}
