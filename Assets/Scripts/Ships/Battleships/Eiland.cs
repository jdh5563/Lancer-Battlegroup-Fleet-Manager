using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eiland : Ship
{
	protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new SuperiorLogistics());
        actions.Add(new CombatRefit());
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

	class SuperiorLogistics : Trait
	{
        public SuperiorLogistics()
        {
            traitName = "Superior Logistics";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        }
	}

    class CombatRefit : Action
    {
        public CombatRefit() : base()
        {
            actionName = "Combat Refit";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
            tags.Add(Tag.Limited, 1);
        }
    }
}
