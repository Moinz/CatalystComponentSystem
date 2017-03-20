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

public class SpellComponent : MonoBehaviour, ISpellComponent
{
    [Header("Exposed Variables")]
    [SerializeField]
    float range;

    [SerializeField]
    float manaCost;

    [SerializeField]
    int cost;

    #region Properties
    public int Cost
    {
        get
        {
            return cost;
        }
    }

    public float ManaCost
    {
        get
        {
            return manaCost;
        }
    }

    public float Range
    {
        get
        {
            return range;
        }
    }
    #endregion

    public virtual void Fire(Vector3 direction)
    {
        // Needs implementation of Fire
        Debug.Log("Basic Spell: " + direction);
    }

    public virtual void Initialize (int points)
    {
        // Procedural Generation of the Spell Component, Needs Implementation
        manaCost = points / 2;
        range = points / 5;
        cost = Mathf.RoundToInt((Range * 2) - ManaCost);
    }

    public override string ToString()
    {
        return "Hand";
    }
}
