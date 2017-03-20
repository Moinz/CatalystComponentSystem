using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellComponentPentagram : SpellComponent
{
	public override void Fire(Vector3 direction)
    {
        Debug.Log("Pentagram Attack: " + direction.ToString());
    }

    public override string ToString()
    {
        return "Pentagram";
    }
}
