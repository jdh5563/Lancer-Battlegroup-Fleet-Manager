using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tolumnia : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new SynchronizedBatteries());
		traits.Add(new SpecializedMountings());
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

	class SynchronizedBatteries : Trait
	{
		public SynchronizedBatteries()
		{
			traitName = "Synchronized Batteries";
			mechanicalText = MiscData.HURON_FLAVOR;
		}
	}

    class SpecializedMountings : Trait
    {
        public SpecializedMountings()
        {
            traitName = "Specialized Mountings";
            mechanicalText = "This ship cannot equip Payload weapons.";
        }
    }
}
