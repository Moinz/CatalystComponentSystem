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

public class SpellBook : MonoBehaviour 
{
    [Header("Main Components")]
    [SerializeField]
    SpellComponent spellComponent;
    [SerializeField]
    UltimateComponent ultimateComponent;
    [SerializeField]
    SpellEffect spellEffect;

    private void Start()
    {
        GenerateSpellbook();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            CastSpell();

        if (Input.GetMouseButtonDown(3))
            CastUltimate();
    }
    void GenerateSpellbook ()
    {
        spellComponent = Instantiate<SpellComponent>(SeedManager.Instance.GetSpellComponent());
        spellComponent.transform.SetParent(transform);
        spellComponent.Initialize(25);
        spellComponent.name = "Balthazar's " + spellComponent.ToString();

        ultimateComponent = Instantiate<UltimateComponent>(SeedManager.Instance.GetUltimateComponent());
        ultimateComponent.transform.SetParent(transform);
        ultimateComponent.Initialize(25);
        ultimateComponent.name = "Balthazar's " + ultimateComponent.ToString();
    }

    void CastSpell()
    {
        spellComponent.Fire(Input.mousePosition);
    }

    void CastUltimate()
    {
        ultimateComponent.Ultimate(Input.mousePosition);
    }
}
