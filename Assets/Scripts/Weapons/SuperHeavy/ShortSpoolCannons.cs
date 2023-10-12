using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ShortSpoolCannons : SuperHeavyWeapon
{
    private void Awake()
    {
        flavorText = MiscData.FLAK_SCREEN_TEXT;
        mechanicalText = MiscData.FLAK_SCREEN_TEXT;
        tags.Add(Tag.Reliable, 2);
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{

	}
}
