using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellComponentTwinned : SpellComponent
{

	public override void Fire(Vector3 direction)
    {
        Debug.Log("Twinned Attack: " + direction.ToString());
    }

    public override string ToString()
    {
        return "Twinned";
    }
}
