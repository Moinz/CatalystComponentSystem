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
*   	The base class for the Ultimate Spells
*   </summary>
*/

namespace CrimsonCouncil.Moin.Catalyst
{
    public class UltimateComponent : MonoBehaviour, IUltimateComponent
    {

        public virtual void Ultimate(Vector3 position)
        {
            Debug.Log("Ultimate Spell: " + position.ToString());
        }

        public virtual void Initialize(int points)
        {
            name = "Balthazar's " + this.ToString();
        }

        public override string ToString()
        {
            return "Ultimate Spell";
        }
    }
}