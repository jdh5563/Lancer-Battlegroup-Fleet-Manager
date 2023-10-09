using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huron : Ship
{
	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		flavorText = LongStrings.HURON_FLAVOR;
		traits.Add(new FlakScreen());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display()
	{
		
	}

	class FlakScreen : Trait
	{
		public FlakScreen()
		{
			traitName = "Flak Screen";
			mechanicalText = LongStrings.FLAK_SCREEN_TEXT;
		}
	}
}
