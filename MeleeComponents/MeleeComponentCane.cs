using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Cane Variation of the Melee Components
*   </summary>
*/

public class MeleeComponentCane : MeleeComponent
{
    public override void Attack(Vector3 direction)
    {
        Debug.Log("Cane Attack: " + direction.ToString());
    }

    public override string ToString()
    {
        return "Cane";
    }
}
