using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huron : Ship
{
	private void Awake()
	{
		flavorText = LongStrings.HURON_FLAVOR;
	}

	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		traits.Add(new FlakScreen());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab);
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
