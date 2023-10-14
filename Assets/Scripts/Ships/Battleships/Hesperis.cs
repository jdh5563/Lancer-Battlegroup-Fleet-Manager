using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hesperis : Ship
{
	protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new ImpactAssurance());
        traits.Add(new SCKV());
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

	class ImpactAssurance : Trait
	{
        public ImpactAssurance()
        {
            traitName = "Impact-Assurance Targeting";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        }
	}

    class SCKV : Trait
    {
        public SCKV()
        {
            traitName = "Self-Contained Kill Vehicles";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        }
    }
}
