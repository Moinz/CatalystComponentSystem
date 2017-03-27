using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright � 2017 All Rights Reserved
*	
*	<summary>  
*   	The Interface for the Melee Components for the Catalyst
*   </summary>
*/

namespace CrimsonCouncil.Moin.Catalyst
{
    public interface IMeleeComponent
    {
        float Damage { get; }
        float AttackSpeed { get; }

        void Attack(int index);
        void Initialize(int points);
    }
}