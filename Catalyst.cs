using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	The Catalyst is the main component for the player
*   </summary>
*/

public class Catalyst : MonoBehaviour 
{
    [Header("Main Components")]
    [SerializeField]
    MeleeComponent meleeComponent;
    [SerializeField]
    CurseComponent curseComponent;
    [SerializeField]
    MeleeEffect meleeEffect;

    public int assignedPoints;

    private void Start ()
    {
        GenerateCatalyst(0, "Balthazar's");
        assignedPoints = 25;
    }
    private void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void GenerateCatalyst(int index)
    {
        meleeComponent = Instantiate(SeedManager.Instance.GetMeleeComponent());
        meleeComponent.transform.parent = transform;
        meleeComponent.Initialize(assignedPoints);
    }

    void GenerateCatalyst(int index, string name)
    {
        meleeComponent = Instantiate(SeedManager.Instance.GetMeleeComponent());
        meleeComponent.transform.parent = transform;
        meleeComponent.Initialize(assignedPoints);
        meleeComponent.name = name + " " + meleeComponent.ToString();
    }

    void Attack ()
    {
        meleeComponent.Attack(Input.mousePosition);

        if (curseComponent != null)
            curseComponent.Curse();

        if (meleeEffect != null)
            meleeEffect.Effect(Input.mousePosition);
    }
}
