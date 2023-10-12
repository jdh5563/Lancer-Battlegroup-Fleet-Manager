using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarineLanders : Subline
{
	private void Awake()
	{
		flavorText = MiscData.HURON_FLAVOR;
		tags.Add(Tag.Boarding, 10);
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
}
