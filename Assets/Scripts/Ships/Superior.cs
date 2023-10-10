using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superior : Ship
{
	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		flavorText = LongStrings.HURON_FLAVOR;
		traits.Add(new RepairDrones());
		actions.Add(new FleetTriage());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel)
	{
		
	}

	class RepairDrones : Trait
	{
		public RepairDrones()
		{
			traitName = "Repair Drones";
			mechanicalText = LongStrings.FLAK_SCREEN_TEXT;
		}
	}

	class FleetTriage : Action
	{
		public FleetTriage() : base()
		{
			actionName = "Fleet Triage";
			mechanicalText = LongStrings.FLAK_SCREEN_TEXT;
			isTactic = true;
			minRange = LongStrings.NO_RANGE;
			maxRange = LongStrings.NO_RANGE;
            tags.Add(Tag.Limited, 1);
        }
	}
}
