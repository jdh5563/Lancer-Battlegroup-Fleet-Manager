using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class LongCycleLance : SuperHeavyWeapon
{
    protected override void Awake()
    {
        base.Awake();

        flavorText = MiscData.FLAK_SCREEN_TEXT;
        tags.Add(Tag.Charge, 3);
        tags.Add(Tag.Critical, 0);
        tags.Add(Tag.Reliable, 3);
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
