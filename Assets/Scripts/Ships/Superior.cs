using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superior : Ship
{
	private void Awake()
	{
		flavorText = MiscData.HURON_FLAVOR;
	}

	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		traits.Add(new RepairDrones());
		actions.Add(new FleetTriage());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);
	}

	class RepairDrones : Trait
	{
		public RepairDrones()
		{
			traitName = "Repair Drones";
			mechanicalText = MiscData.FLAK_SCREEN_TEXT;
		}
	}

	class FleetTriage : Action
	{
		public FleetTriage() : base()
		{
			actionName = "Fleet Triage";
			mechanicalText = MiscData.FLAK_SCREEN_TEXT;
			isTactic = true;
			minRange = MiscData.NO_RANGE;
			maxRange = MiscData.NO_RANGE;
            tags.Add(Tag.Limited, 1);
        }
	}
}
