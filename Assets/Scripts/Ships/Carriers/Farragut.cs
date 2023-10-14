using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farragut : Ship
{
	protected override void Awake()
    {
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new ModularDesign());
        traits.Add(new FleetCoordinator());
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

	class ModularDesign : Trait
	{
		public ModularDesign()
		{
			traitName = "Modular Design";
			mechanicalText = "This ship has a special modular slot that can be used to equip an Auxiliary weapon, a System, an Escort, or a Wing.";
		}
	}

    class FleetCoordinator : Trait
    {
        public FleetCoordinator()
        {
            traitName = "Fleet Coordinator";
            mechanicalText = "When you assign a Frigate to a Defensive Screen, it may screen for up to two ships at once.";
        }
    }
}
