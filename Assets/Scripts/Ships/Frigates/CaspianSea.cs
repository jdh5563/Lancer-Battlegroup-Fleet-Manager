using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CaspianSea : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.CASPIAN_FLAVOR;
		traits.Add(new FireControlNetworking());
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

	class FireControlNetworking : Trait
	{
		public FireControlNetworking()
		{
			traitName = "Fire Control Networking";
			mechanicalText = MiscData.FCN_TEXT;
		}
	}
}
