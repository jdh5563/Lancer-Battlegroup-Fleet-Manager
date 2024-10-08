using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class LegionDrone : Subline
{
	protected override void Awake()
	{
		base.Awake();

		flavorText = MiscData.HURON_FLAVOR;
		mechanicalText = MiscData.HURON_FLAVOR;
		tactics.Add(new LegionCommand());
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

	class LegionCommand : Action
	{
		public LegionCommand() : base()
		{
			minRange = 0;
			maxRange = 3;
			mechanicalText = MiscData.HURON_FLAVOR;
		}
	}
}
