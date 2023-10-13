using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cirsium : Ship
{
	protected override void Awake()
	{
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
		traits.Add(new HonorGuard());
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

	class HonorGuard : Trait
	{
		public HonorGuard()
		{
			traitName = "Honor Guard";
			mechanicalText = "1/round when this ship takes damage from any source while it has an Escort equipped, it instead takes 0 damage and the Escort takes that amount of damage instead.";
		}
	}
}
