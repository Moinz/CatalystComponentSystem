using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Interface for the Ultimate Spells
*   </summary>
*/

public interface IUltimateComponent
{
    int Cost { get; }

    void Ultimate(Vector3 position);
    void Initialize(int points);
}
