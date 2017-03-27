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

namespace CrimsonCouncil.Moin.Catalyst
{
    public interface IEffectComponent
    {
        IEnumerator Effect(Vector3 position);
        void Initialize();
    }
}