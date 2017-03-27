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

namespace CrimsonCouncil.Moin.Catalyst
{
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
            GenerateCatalyst(0);
            assignedPoints = 25;
        }
        private void Update ()
        {
            if (Input.GetButtonDown("Melee"))
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

        void Attack ()
        {
            meleeComponent.Attack(PlayerMovement.PlayerDirectionIndex);

            if (curseComponent != null)
                curseComponent.Curse();

            if (meleeEffect != null)
                meleeEffect.Effect(Input.mousePosition);
        }
    }
}