using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class FlyswatterMissiles : AuxiliaryWeapon
{
    private void Awake()
    {
        flavorText = MiscData.FLAK_SCREEN_TEXT;
        mechanicalText = "When fired alongside any Primary weapon, this weapon deals 2 damage to up to 2 Wings in the target's battlegroup.";
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
