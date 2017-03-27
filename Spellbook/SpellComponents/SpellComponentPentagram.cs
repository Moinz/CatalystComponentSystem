using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrimsonCouncil.Moin.Catalyst
{
    public class SpellComponentPentagram : SpellComponent
    {
        public override void Fire(int directionIndex)
        {
            int tempIndex = HandleIndex(directionIndex, 0);
            HandleProjectile(tempIndex);

            tempIndex = HandleIndex(directionIndex, -1);
            HandleProjectile(tempIndex);

            tempIndex = HandleIndex(directionIndex, 1);
            HandleProjectile(tempIndex);

            tempIndex = HandleIndex(directionIndex, -3);
            HandleProjectile(tempIndex);

            tempIndex = HandleIndex(directionIndex, 3);
            HandleProjectile(tempIndex);
        }

        public override string ToString()
        {
            return "Pentagram";
        }
    }
}