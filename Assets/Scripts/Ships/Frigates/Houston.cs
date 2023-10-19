using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Houston : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new EnhancedLogistics());
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

	public void AddTraitTag(GameObject text)
	{
		EnhancedLogistics trait = (EnhancedLogistics)traits[0];
		trait.AddTag(text);
	}

	class EnhancedLogistics : Trait
	{
		public Tuple<Tag, int> TraitTag
		{
			get; private set;
		}

		public EnhancedLogistics()
		{
			traitName = "Enhanced Logistics";
			mechanicalText = MiscData.HURON_FLAVOR;
			TraitTag = new Tuple<Tag, int>(Tag.Limited, 2);
		}

		public void AddTag(GameObject text)
		{
			text.GetComponent<TMP_Text>().text += ", " + TraitTag.Item1.ToString() + " " + TraitTag.Item2.ToString();
		}
	}
}
