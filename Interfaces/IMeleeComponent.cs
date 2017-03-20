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

public interface IMeleeComponent
{
    float Damage { get; }
    float AttackSpeed { get; }
    int Cost { get; }

    void Attack(Vector3 direction);
    void Initialize(int points);
}
