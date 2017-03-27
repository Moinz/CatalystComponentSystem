using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrimsonCouncil.Moin.Catalyst
{
    public class MeleeComponent : MonoBehaviour, IMeleeComponent
    {
        [Header("Exposed Variables")]
        [SerializeField]
        float attackSpeed;
        [SerializeField]
        float damage;
        [SerializeField]
        public Slash slash;
        EffectComponent onHitEffect;


        #region Properties
        public float AttackSpeed
        {
            get
            {
                return attackSpeed;
            }
        }

        public float Damage
        {
            get
            {
                return damage;
            }
        }

        public Slash Slash
        {
            get
            {
                return slash;
            }
        }

        public string Name { get; set; }
        #endregion

        public virtual void Attack(int index)
        {
            Vector2 direction = PlayerMovement.Directions[index];
            Slash temp = Instantiate(slash, transform.position + PlayerMovement.Origins[index], Quaternion.identity);
            temp.transform.parent = transform;

            EffectComponent tempEffect = Instantiate(onHitEffect, temp.transform.position, Quaternion.identity);
            tempEffect.transform.parent = temp.transform;

        }

        public virtual void Initialize(int points)
        {
            // Melee Component Logic here
            damage = points / 5;
            attackSpeed = points / 10;

            onHitEffect = SeedManager.Instance.GetOnHitEffect();

            name = "Balthazar's " + ToString();
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}