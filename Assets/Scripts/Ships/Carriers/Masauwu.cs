using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masauwu : Ship
{
	protected override void Awake()
    {
		base.Awake();
		flavorText = MiscData.HURON_FLAVOR;
        traits.Add(new Wolfpack());
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

	class Wolfpack : Trait
	{
		public Wolfpack()
		{
			traitName = "Wolfpack Tactics";
			mechanicalText = "1/round when you use a tactic to command one of this ship's Escorts, you may also issue a command to another of its Escorts or Wings for free.";
		}
	}
}
