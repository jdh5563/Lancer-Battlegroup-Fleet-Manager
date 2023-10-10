using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creighton : Ship
{
	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		flavorText = LongStrings.HURON_FLAVOR;
		traits.Add(new PurposeBuilt());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel)
	{
		
	}

	class PurposeBuilt : Trait
	{
		public PurposeBuilt()
		{
			traitName = "Purpose-Built";
			mechanicalText = LongStrings.FLAK_SCREEN_TEXT;
		}
	}

    class Vega : Trait
    {
        public Vega()
        {
            traitName = "VEGA-Pattern Targeting Laser";
            mechanicalText = LongStrings.FLAK_SCREEN_TEXT;
        }
    }

    class Calibrated : Trait
    {
        public Calibrated()
        {
            traitName = "Calibrated Firing Platform";
            mechanicalText = LongStrings.FLAK_SCREEN_TEXT;
        }
    }
}
