using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laho : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new RotaryLaunch());
        traits.Add(new TorpedoBoat());
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

	class RotaryLaunch : Trait
	{
		public RotaryLaunch()
		{
			traitName = "Rotary Launch Tubes";
			mechanicalText = "You may choose to reduce the starting Flight Counters of any Payload weapon equipped to this ship by 1, to a minimum of 1."; ;
		}
	}

    class TorpedoBoat : Trait
    {
        public TorpedoBoat()
        {
            traitName = "Torpedo Boat";
			mechanicalText = "This ship can only equip Primary weapons with the Payload tag.";
        }
    }
}
