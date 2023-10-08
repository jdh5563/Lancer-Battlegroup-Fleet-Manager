using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ship : BGComponent
{
    [SerializeField] protected bool isFlagship;
    [SerializeField] protected string shipName;
    [SerializeField] protected string playerDesc;
    [SerializeField] protected string company;
    [SerializeField] protected int hp;
    [SerializeField] protected uint defense;
    [SerializeField] protected uint auxSlots;
    [SerializeField] protected uint primSlots;
    [SerializeField] protected uint sHeavySlots;
	[SerializeField] protected uint systemSlots;
    [SerializeField] protected uint wingSlots;
    [SerializeField] protected uint escortSlots;

	[SerializeField] protected List<AuxiliaryWeapon> auxWeapons;
	[SerializeField] protected List<PrimaryWeapon> primWeapons;
	[SerializeField] protected List<SuperHeavyWeapon> sHeavyWeapons;
    [SerializeField] protected List<ShipSystem> systems;
    [SerializeField] protected List<Wing> wings;
    [SerializeField] protected List<Escort> escorts;
    [SerializeField] protected List<Legacy> legacies;
    [SerializeField] protected List<Trait> traits;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
