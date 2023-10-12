using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class VegaLaser : PrimaryWeapon
{
    private void Awake()
    {
        flavorText = "";
        mechanicalText = "On hit, Lock On to the target.";
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
