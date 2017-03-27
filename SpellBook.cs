using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Implementation of the Spellbook
*   </summary>
*/

namespace CrimsonCouncil.Moin.Catalyst
{
    public class SpellBook : MonoBehaviour
    {
        [Header("Main Components")]
        [SerializeField]
        SpellComponent spellComponent;
        [SerializeField]
        UltimateComponent ultimateComponent;
        [SerializeField]
        EffectComponent Effect;

        private void Start()
        {
            GenerateSpellbook();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Spell"))
                CastSpell();

            if (Input.GetButtonDown("Melee"))
                CastUltimate();
        }
        void GenerateSpellbook()
        {

            spellComponent = Instantiate<SpellComponent>(SeedManager.Instance.GetSpellComponent());
            spellComponent.transform.SetParent(transform);
            spellComponent.Initialize(25);


            ultimateComponent = Instantiate<UltimateComponent>(SeedManager.Instance.GetUltimateComponent());
            ultimateComponent.transform.SetParent(transform);
            ultimateComponent.Initialize(25);
        }
        void CastSpell()
        {
            spellComponent.Fire(PlayerMovement.PlayerDirectionIndex);
        }

        void CastUltimate()
        {
            ultimateComponent.Ultimate(Input.mousePosition);
        }
    }
}