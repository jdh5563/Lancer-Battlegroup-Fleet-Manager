using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PrimaryWeapon : Weapon
{
	[SerializeField] protected Dictionary<Tag, int> tags;
	[SerializeField] protected bool isSingleTarget;
    [SerializeField] protected uint[] damage = new uint[3]; // d6s, d3s, flat damage

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        isSingleTarget = true;
        tags = new Dictionary<Tag, int>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
