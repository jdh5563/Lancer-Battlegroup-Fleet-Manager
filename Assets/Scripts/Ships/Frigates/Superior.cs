using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superior : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new RepairDrones());
		actions.Add(new FleetTriage());
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

	class RepairDrones : Trait
	{
		public RepairDrones()
		{
			traitName = "Repair Drones";
			mechanicalText = "When this Frigate is assigned to a Defensive Screen, the ship it is screening for repairs 2HP.";
		}
	}

	class FleetTriage : Action
	{
		public FleetTriage() : base()
		{
			actionName = "Fleet Triage";
			mechanicalText = "One of your Capital Ships or Escorts, or an allied Capital Ship or Escort in your range band, repairs 5HP."; ;
            tags.Add(Tag.Limited, 1);
        }
	}
}
