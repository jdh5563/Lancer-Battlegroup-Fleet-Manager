using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class KineticProjectors : PrimaryWeapon
{
    private void Awake()
    {
        flavorText = MiscData.FLAK_SCREEN_TEXT;
        mechanicalText = "Attacks with this weapon from further than Range 1 receive +1 Difficulty.";
        tags.Add(Tag.Critical, 0);
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
