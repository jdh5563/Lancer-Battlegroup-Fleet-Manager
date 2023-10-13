using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turenne : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new ActiveDefense());
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

	class ActiveDefense : Trait
	{
		public ActiveDefense()
		{
			traitName = "Active Defense";
			mechanicalText = "When this ship is assigned to a Defensive Screen, that battlegroup gains +3 Interdiction.";
		}
	}
}
