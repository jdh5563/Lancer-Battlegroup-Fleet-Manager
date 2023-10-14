using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greenland : Ship
{
	protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new HookJab());
        actions.Add(new BodyBlow());
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

	class HookJab : Trait
	{
        public HookJab()
        {
            traitName = "Hook-Jab";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        }
	}

    class BodyBlow : Action
    {
        public BodyBlow() : base()
        {
            actionName = "Body Blow";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
            isTactic = false;
            tags.Add(Tag.Limited, 1);
        }
    }
}
