using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrimsonCouncil.Moin.Catalyst;
/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Seed Manager that handles all randomisation
*   </summary>
*/

public class SeedManager : MonoBehaviourSingleton<SeedManager>
{
    public List<WeightedObject> meleeComponents;
    public List<WeightedObject> spellComponents;
    public List<WeightedObject> ultimateComponents;
    public List<WeightedObject> projectileComponents;
    public List<WeightedObject> onHitEffects;

    public MeleeComponent GetMeleeComponent()
    {
        // Returns a random melee component from a list of all melee components
        int r = Random.Range(0, meleeComponents.Count);
        return meleeComponents[r].gameObject.GetComponent<MeleeComponent>();
    }
    
    public SpellComponent GetSpellComponent ()
    {
        // Returns a random spell component from a list of all spell components
        int r = Random.Range(0, spellComponents.Count);
        return spellComponents[r].gameObject.GetComponent<SpellComponent>();
    }

    public UltimateComponent GetUltimateComponent ()
    {
        int r = Random.Range(0, ultimateComponents.Count);
        return ultimateComponents[r].gameObject.GetComponent<UltimateComponent>();
    }

    public Projectile GetProjectileComponent()
    {
        int r = Random.Range(0, ultimateComponents.Count);
        return projectileComponents[r].gameObject.GetComponent<Projectile>();
    }

    public EffectComponent GetOnHitEffect()
    {
        int r = Random.Range(0, onHitEffects.Count);
        return onHitEffects[r].gameObject.GetComponent<EffectComponent>();
    }
}
