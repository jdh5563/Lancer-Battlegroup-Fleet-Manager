using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggressiveCommanders : ShipSystem
{
    protected override void Awake()
    {
        base.Awake();

        flavorText = MiscData.FLAK_SCREEN_TEXT;
        mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        tags.Add(Tag.Unique, 0);
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
    {
		base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);
	}
}
