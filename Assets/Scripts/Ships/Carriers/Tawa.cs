using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tawa : Ship
{
	protected override void Awake()
    {
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new AwayTeams());
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

	class AwayTeams : Trait
	{
		public AwayTeams()
		{
			traitName = "Away Teams";
			mechanicalText = "This ship's Boarding upgrades gain +2 Tenacity.";
		}
	}
}
