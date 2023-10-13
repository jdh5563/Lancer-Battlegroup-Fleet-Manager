using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minokawa : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new RapidReaction());
        traits.Add(new PatrolCutter());
    }

	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);
	}

	class RapidReaction : Trait
	{
		public RapidReaction()
		{
			traitName = "Rapid Reaction Force";
			mechanicalText = MiscData.HURON_FLAVOR;
		}
	}

    class PatrolCutter : Trait
    {
        public PatrolCutter()
        {
            traitName = "Patrol Cutter";
            mechanicalText = MiscData.HURON_FLAVOR;
        }
    }
}
