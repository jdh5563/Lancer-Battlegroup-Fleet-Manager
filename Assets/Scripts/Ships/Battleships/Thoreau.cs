using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thoreau : Ship
{
    private void Awake()
    {
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new BarrageDoctrine());
        actions.Add(new UnleashHell());
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

	class BarrageDoctrine : Trait
	{
		public BarrageDoctrine()
		{
			traitName = "Barrage Doctrine";
			mechanicalText = "When you fire a Primary weapon as part of All Ahead Full, you may use 2 Auxiliary weapons alongside it instead of 1.";
		}
	}

    class UnleashHell : Action
    {
        public UnleashHell() : base()
        {
            actionName = "Unleash Hell";
            mechanicalText = MiscData.FLAK_SCREEN_TEXT;
            isTactic = false;
            tags.Add(Tag.Limited, 1);
        }
    }
}
