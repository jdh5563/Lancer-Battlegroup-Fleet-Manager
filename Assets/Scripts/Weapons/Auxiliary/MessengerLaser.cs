using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class MessengerLaser : AuxiliaryWeapon
{
    protected override void Awake()
    {
        base.Awake();

        flavorText = MiscData.FLAK_SCREEN_TEXT;
        mechanicalText = MiscData.FLAK_SCREEN_TEXT;
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
