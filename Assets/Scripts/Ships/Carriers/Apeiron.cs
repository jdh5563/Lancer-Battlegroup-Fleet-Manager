using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apeiron : Ship
{
	protected override void Awake()
    {
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new SingularityCatapults());
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

	class SingularityCatapults : Trait
	{
		public SingularityCatapults()
		{
			traitName = "Singularity Catapults";
			mechanicalText = "Wings equipped by this ship increase both the maximum and minimum range of all of their effects and abilities by 1.";
		}
	}
}
