using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Seed Manager that handles all randomisation
*   </summary>
*/

public class SeedManager : Singleton<SeedManager>
{
    public List<MeleeComponent> meleeComponents;
    public List<SpellComponent> spellComponents;
    public List<UltimateComponent> ultimateComponents;

    public MeleeComponent GetMeleeComponent()
    {
        // Returns a random melee component from a list of all melee components
        int r = Random.Range(0, meleeComponents.Count);
        return meleeComponents[r];
    }
    
    public SpellComponent GetSpellComponent ()
    {
        // Returns a random spell component from a list of all spell components
        int r = Random.Range(0, spellComponents.Count);
        return spellComponents[r];
    }

    public UltimateComponent GetUltimateComponent ()
    {
        int r = Random.Range(0, ultimateComponents.Count);
        return ultimateComponents[r];
    }
}
