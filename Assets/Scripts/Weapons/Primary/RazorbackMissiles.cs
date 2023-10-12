using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class RazorbackMissiles : PrimaryWeapon
{
    private void Awake()
    {
        flavorText = MiscData.FLAK_SCREEN_TEXT;
        mechanicalText = "You may consume Lock On as part of firing this weapon to add or remove 1 Flight Counter from it.";
        tags.Add(Tag.Payload, 0);
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
