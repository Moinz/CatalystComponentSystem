using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	
*	Dennis Foose
* 	Crimson Council Studentbedrift
*	Copyright © 2017 All Rights Reserved
*	
*	<summary>  
*   	Weighted Object Script which allows for weighted list, 
*   	and also a cleaner reference to cost.
*   </summary>
*/
[System.Serializable]
public struct WeightedObject
{
    public float weight;
    public int cost;
    public GameObject gameObject;
}
