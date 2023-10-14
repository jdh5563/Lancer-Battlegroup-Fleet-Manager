using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Louis : Ship
{
	protected override void Awake()
    {
        base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new Pinpoint());
        actions.Add(new ProjectedBlackshield());
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

	class Pinpoint : Trait
	{
		public Pinpoint()
		{
			traitName = "Pinpoint Aegis";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
		}
	}

    class ProjectedBlackshield : Action
    {
        public ProjectedBlackshield() : base()
        {
            actionName = "Projected Blackshield";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
            tags.Add(Tag.Limited, 1);
        }
    }
}
