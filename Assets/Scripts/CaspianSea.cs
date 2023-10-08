using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaspianSea : Ship
{
	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		flavorText = LongStrings.CASPIAN_FLAVOR;
		traits.Add(new FireControlNetworking());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	protected override void Display()
	{
		
	}

	class FireControlNetworking : Trait
	{
		public FireControlNetworking()
		{
			traitName = "Fire Control Networking";
			mechanicalText = LongStrings.FCN_TEXT;
		}
	}
}
