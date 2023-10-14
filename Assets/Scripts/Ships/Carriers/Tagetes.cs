using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagetes : Ship
{
	protected override void Awake()
    {
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new LeadDancer());
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

	class LeadDancer : Trait
	{
		public LeadDancer()
		{
			traitName = "Lead Dancer";
			mechanicalText = "This ship's Wings deal +1 damage with all non-Boarding damage effects, and damage they take from hostile sources is reduced by 1.";
		}
	}
}
