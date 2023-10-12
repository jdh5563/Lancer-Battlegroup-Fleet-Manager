using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creighton : Ship
{
    protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new PurposeBuilt());
		traits.Add(new Calibrated());
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

	class PurposeBuilt : Trait
	{
		public PurposeBuilt()
		{
			traitName = "Purpose-Built";
			mechanicalText = MiscData.FLAK_SCREEN_TEXT;
		}
	}

    class Vega : Trait
    {
        public Vega()
        {
            traitName = "VEGA-Pattern Targeting Laser";
            mechanicalText = "This ship is equipped with an integrated long-range \"hot\" targeting laser matrix that counts as a Primary weapon.";
        }
    }

    class Calibrated : Trait
    {
        public Calibrated()
        {
            traitName = "Calibrated Firing Platform";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        }
    }
}
