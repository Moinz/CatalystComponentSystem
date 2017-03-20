using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Interface for the Spell Components
*   </summary>
*/

public interface ISpellComponent
{
    float Range { get; }
    float ManaCost { get; }
    int Cost { get; }

    void Fire(Vector3 direction);
    void Initialize(int points); 
}
