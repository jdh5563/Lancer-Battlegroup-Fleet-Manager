using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amazon : Ship
{
	protected override void Awake()
    {
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new RapidPrinting());
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

	class RapidPrinting : Trait
	{
		public RapidPrinting()
		{
			traitName = "Rapid Printing";
			mechanicalText = MiscData.FLAK_SCREEN_TEXT;
		}
	}
}
