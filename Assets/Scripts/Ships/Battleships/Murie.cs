using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murie : Ship
{
    private void Awake()
    {
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new Paragon());
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

	class Paragon : Trait
	{
		public Paragon()
		{
			traitName = "Paragon";
			mechanicalText = MiscData.FLAK_SCREEN_TEXT;
		}
	}
}
