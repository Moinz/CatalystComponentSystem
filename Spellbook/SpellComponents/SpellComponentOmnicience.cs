using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CrimsonCouncil.Moin.Catalyst
{
    public class SpellComponentOmnicience : SpellComponent
    {
        public override void Fire(int directionIndex)
        {
            for (int i = 1; i <= 8; i++)
            {
                HandleProjectile(i);
            }
        }

        public override string ToString()
        {
            return "Omnicience";
        }
    }
}