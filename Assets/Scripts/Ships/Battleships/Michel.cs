using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Michel : Ship
{
	protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new Blinkspace());
        actions.Add(new Blinktunneler());
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

	class Blinkspace : Trait
	{
		public Blinkspace()
		{
			traitName = "Blinkspace Carver";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
		}
	}

    class Blinktunneler : Action
    {
        public Blinktunneler() : base()
        {
            actionName = "Tactical Blinktunneler";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
            isTactic = false;
            tags.Add(Tag.Limited, 1);
        }
    }
}
