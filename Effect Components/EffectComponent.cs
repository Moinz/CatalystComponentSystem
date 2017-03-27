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
*   	Base Class for Spell Effects
*   </summary>
*/

namespace CrimsonCouncil.Moin.Catalyst
{
    public class EffectComponent : MonoBehaviour, IEffectComponent
    {
        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerator Effect (Vector3 position)
        {
            Debug.Log("On Hit Effect Started");
            yield return new WaitForSeconds(0.25f);
            Debug.Log("On Hit Effect Done");
            Destroy(transform.parent.gameObject);
        }
    }
}