using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Interface for Curses
*   </summary>
*/

namespace CrimsonCouncil.Moin.Catalyst
{
    public interface ICurseComponent
    {
        void Curse();
        void Initialize();
    }
}