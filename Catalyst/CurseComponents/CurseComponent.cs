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
*   	Description Here
*   </summary>
*/

namespace CrimsonCouncil.Moin.Catalyst
{
    public class CurseComponent : MonoBehaviour, ICurseComponent
    {
        public void Curse()
        {
            Debug.Log("Cuuuuuurse");
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}