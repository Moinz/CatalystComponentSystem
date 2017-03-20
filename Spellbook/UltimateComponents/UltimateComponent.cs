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

public class UltimateComponent : MonoBehaviour, IUltimateComponent
{
    [Header("Exposed Fields")]
    [SerializeField]
    int cost;

    public int Cost
    {
        get
        {
            return cost;
        }
    }
    public virtual void Ultimate(Vector3 position)
    {
        Debug.Log("Ultimate Spell: " + position.ToString());
    }

    public virtual void Initialize(int points)
    {
        cost = points;
    }

    public override string ToString()
    {
        return "Ultimate Spell";
    }
}
