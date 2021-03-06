
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CrimsonCouncil.Moin.Catalyst
{
    public class SpellComponentTwinned : SpellComponent
    {
        public override void Fire(int directionIndex)
        {
            int tempIndex = HandleIndex(directionIndex, 0);
            HandleProjectile(tempIndex);

            tempIndex = HandleIndex(directionIndex, 4);
            HandleProjectile(tempIndex);
        }

        public override string ToString()
        {
            return "Twinned";
        }
    }
}