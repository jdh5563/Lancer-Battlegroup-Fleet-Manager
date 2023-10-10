using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CaspianSea : Ship
{
	private void Awake()
	{
		flavorText = LongStrings.CASPIAN_FLAVOR;
	}

	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		traits.Add(new FireControlNetworking());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab);
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
