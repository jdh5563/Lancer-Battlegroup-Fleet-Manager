using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SuperHeavyWeapon : Weapon
{
    [SerializeField] protected Dictionary<Tag, int> tags;
    [SerializeField] protected bool isSingleTarget;
    [SerializeField] protected uint[] damage = new uint[3]; // d6s, d3s, flat damage

    protected override void Awake()
    {
        base.Awake();

		tags = new Dictionary<Tag, int>();
	}

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        isSingleTarget = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
