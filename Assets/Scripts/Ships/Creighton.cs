using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creighton : Ship
{
    private void Awake()
    {
		flavorText = MiscData.HURON_FLAVOR;
	}

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
		traits.Add(new PurposeBuilt());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab);
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
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
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
