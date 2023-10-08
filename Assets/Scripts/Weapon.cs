using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : BGComponent
{
	[SerializeField] protected Dictionary<string, int> tags;
	[SerializeField] protected uint minRange;
	[SerializeField] protected uint maxRange;
    [SerializeField] protected bool isSingleTarget;
    [SerializeField] protected uint[] damageExpression = new uint[3];

	// Start is called before the first frame update
	void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
