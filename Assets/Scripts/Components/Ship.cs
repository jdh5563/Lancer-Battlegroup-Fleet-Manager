using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public Texture2D ShipArt { get { return shipArt; } }

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

    public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab)
    {
        base.Display(infoPanel, textPrefab, buttonPrefab);

		GameObject companyText = Instantiate(textPrefab, infoPanel.transform);
		companyText.GetComponent<RectTransform>().anchoredPosition = new Vector2(-200, 130);
		companyText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 20);
		companyText.GetComponent<TMP_Text>().text = "Company: " + company.ToString();

		GameObject hpText = Instantiate(textPrefab, infoPanel.transform);
		hpText.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 130);
		hpText.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 20);
		hpText.GetComponent<TMP_Text>().text = "HP: " + hp.ToString();

		GameObject defenseText = Instantiate(textPrefab, infoPanel.transform);
		defenseText.GetComponent<RectTransform>().anchoredPosition = new Vector2(240, 130);
		defenseText.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 20);
		defenseText.GetComponent<TMP_Text>().text = "Def: " + defense.ToString();
	}
}
