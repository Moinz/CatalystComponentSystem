using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Sword Variation of the Melee Components
*   </summary>
*/

public class MeleeComponentStaff : MeleeComponent
{
    public override void Attack(Vector3 direction)
    {
        Debug.Log("Staff Attack: " + direction.ToString());
    }

    public override string ToString()
    {
        return "Staff";
    }
}
