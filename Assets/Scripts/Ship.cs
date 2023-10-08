using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Company
{
    GMS,
    FKS,
    HA,
    IPSN,
}

public abstract class Ship : BGComponent
{
    [SerializeField] protected bool isFlagship;
    [SerializeField] protected string shipName;
    [SerializeField] protected string playerDesc;
    [SerializeField] protected Company company;
    [SerializeField] protected int hp;
    [SerializeField] protected uint defense;
    [SerializeField] protected uint auxSlots;
    [SerializeField] protected uint primSlots;
    [SerializeField] protected uint sHeavySlots;
	[SerializeField] protected uint systemSlots;
    [SerializeField] protected uint wingSlots;
    [SerializeField] protected uint escortSlots;
    [SerializeField] protected Texture2D shipArt;

	[SerializeField] protected List<AuxiliaryWeapon> auxWeapons;
	[SerializeField] protected List<PrimaryWeapon> primWeapons;
	[SerializeField] protected List<SuperHeavyWeapon> sHeavyWeapons;
    [SerializeField] protected List<ShipSystem> systems;
    [SerializeField] protected List<Subline> wings;
    [SerializeField] protected List<Subline> escorts;
    [SerializeField] protected List<Legacy> legacies;
    [SerializeField] protected List<Trait> traits;
    [SerializeField] protected List<Action> actions;


	// Start is called before the first frame update
	protected override void Start()
    {
		isFlagship = false;
		shipName = null;
		playerDesc = null;
		auxSlots = 0;
		primSlots = 0;
		sHeavySlots = 0;
		systemSlots = 0;
		wingSlots = 0;
		escortSlots = 0;
        auxWeapons = new List<AuxiliaryWeapon>();
		primWeapons = new List<PrimaryWeapon>();
        sHeavyWeapons = new List<SuperHeavyWeapon>();
		systems = new List<ShipSystem>();
		wings = new List<Subline>();
		escorts = new List<Subline>();
		legacies = new List<Legacy>();
		traits = new List<Trait>();
		actions = new List<Action>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Display()
    {

    }
}
