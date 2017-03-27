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

namespace CrimsonCouncil.Moin.Catalyst
{
    public class SpellComponent : MonoBehaviour, ISpellComponent
    {
        [Header("Exposed Variables")]
        [SerializeField]
        float range;

        [SerializeField]
        float manaCost;

        [SerializeField]
        Projectile projectile;

        [SerializeField]
        EffectComponent onHitEffect;

        #region Properties

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

        public Projectile Projectile
        {
            get
            {
                return projectile;
            }
        }

        public EffectComponent OnHitEffect
        {
            get
            {
                return onHitEffect;
            }

            set
            {
                value = onHitEffect;
            }
        }
        #endregion

        public virtual void Fire(int directionIndex)
        {
            int tempIndex = HandleIndex(directionIndex, 0);
            HandleProjectile(tempIndex);
        }

        public void HandleProjectile(int handledIndex)
        {
            Vector2 direction = PlayerMovement.Directions[handledIndex];
            Projectile temp = Instantiate(projectile, transform.position + PlayerMovement.Origins[handledIndex], Quaternion.identity);
            temp.transform.parent = transform;

            EffectComponent tempEffect = Instantiate(onHitEffect, temp.transform.position, Quaternion.identity);
            tempEffect.transform.SetParent(temp.transform);
            temp.Launch(direction);
        }

        public int HandleIndex(int index, int amount)
        {
            if (index + amount > 8)
            {
                return index + amount - 8;
            }
            else if (index + amount < 1)
            {
                return index + amount + 8;
            }
            else
            {
                return index + amount;
            }
        }

        public virtual void Initialize(int points)
        {
            name = "Balthazar's " + ToString();
            // Procedural Generation of the Spell Component, Needs Implementation
            manaCost = points / 2;
            range = points / 5;

            onHitEffect = SeedManager.Instance.GetOnHitEffect();
            projectile = SeedManager.Instance.GetProjectileComponent();
        }

        public override string ToString()
        {
            return "Hand";
        }
    }
}