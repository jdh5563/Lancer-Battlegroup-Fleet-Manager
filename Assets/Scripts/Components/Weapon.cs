using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : BGComponent
{
	[SerializeField] protected string mechanicalText;
	[SerializeField] protected uint minRange;
	[SerializeField] protected uint maxRange;
	[SerializeField] protected bool isIntegrated;

    // Start is called before the first frame update
    protected override void Start()
    {
		isIntegrated = false;
		mechanicalText = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	/*
	 SPINAL LINAC COHERENT BEAM CANNON


Superheavy, Single-Target, Charge 2, Critical
[Range 4-1][8 damage][2 points]


An old workhorse, the linear accelerator
coherent beam cannon once marked the
pinnacle of energy weapon development.
Reliable at middle-confidence ranges and,

with modern power systems, capable of rapid-
cycling main battery fire, a LinAc CBC is a

formidable weapon favored by captains who
prefer more traditional strategies.
	 */

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{

	}
}
