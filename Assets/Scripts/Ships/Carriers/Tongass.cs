using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongass : Ship
{
    private void Awake()
    {
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new CloseSupport());
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

	class CloseSupport : Trait
	{
		public CloseSupport()
		{
			traitName = "Close Support";
			mechanicalText = "Allied battlegroups in your range band may use tactics granted by this ship's Escorts as if they were under their control.";
		}
	}
}
