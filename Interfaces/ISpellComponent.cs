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

namespace CrimsonCouncil.Moin.Catalyst
{
    public interface ISpellComponent
    {
        float Range { get; }
        float ManaCost { get; }
        Projectile Projectile { get; }

        void Fire(int directionIndex);
        void Initialize(int points);
    }
}