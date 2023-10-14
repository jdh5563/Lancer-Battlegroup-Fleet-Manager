using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendula : Ship
{
	protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new LastArgument());
        traits.Add(new Overcharge());
        actions.Add(new MaximumPower());
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

	class LastArgument : Trait
	{
		public LastArgument()
		{
			traitName = "Last Argument of Kings";
            mechanicalText = "This ship must have at least one Superheavy Charge weapon.";
		}
	}

    class Overcharge : Trait
    {
        public Overcharge()
        {
            traitName = "Overcharge Capacitors";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        }
    }

    class MaximumPower : Action
    {
        public MaximumPower() : base()
        {
            actionName = "Maximum Power";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
            tags.Add(Tag.Limited, 1);
        }
    }
}
