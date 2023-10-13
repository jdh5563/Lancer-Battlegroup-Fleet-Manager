using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static System.Net.Mime.MediaTypeNames;

public enum Company
{
    GMS,
    FKS,
    HA,
    IPSN,
	SSC
}

public abstract class Ship : BGComponent
{
    [SerializeField] protected bool isFlagship;
    [SerializeField] protected string shipName;
    [SerializeField] protected string playerDesc;
    [SerializeField] protected int hp;
    [SerializeField] protected uint defense;
    [SerializeField] protected uint auxSlots;
    [SerializeField] protected uint primSlots;
    [SerializeField] protected uint sHeavySlots;
	[SerializeField] protected uint systemSlots;
    [SerializeField] protected uint wingSlots;
    [SerializeField] protected uint escortSlots;
    [SerializeField] protected Texture2D shipArt;
	[SerializeField] protected Texture2D companyArt;

	[SerializeField] protected List<AuxiliaryWeapon> auxWeapons = new List<AuxiliaryWeapon>();
	[SerializeField] protected List<PrimaryWeapon> primWeapons = new List<PrimaryWeapon>();
	[SerializeField] protected List<SuperHeavyWeapon> sHeavyWeapons = new List<SuperHeavyWeapon>();
    [SerializeField] protected List<ShipSystem> systems = new List<ShipSystem>();
    [SerializeField] protected List<Subline> wings = new List<Subline>();
    [SerializeField] protected List<Subline> escorts = new List<Subline>();
    [SerializeField] protected List<Legacy> legacies = new List<Legacy>();
    [SerializeField] protected List<Trait> traits = new List<Trait>();
    [SerializeField] protected List<Action> actions = new List<Action>();

	private int slotNum = 0;
	private float x = -185;
	private float y = 85;
	private float longestText = 0f;

	public Texture2D ShipArt { get { return shipArt; } }

    protected override void Awake()
    {
		base.Awake();
	}

	// Start is called before the first frame update
	protected override void Start()
	{
		base.Start();
		isFlagship = false;
		shipName = null;
		playerDesc = null;
		auxSlots = 0;
		primSlots = 0;
		sHeavySlots = 0;
		systemSlots = 0;
		wingSlots = 0;
		escortSlots = 0;
	}

	// Update is called once per frame
	void Update()
    {
        
    }

    public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
    {
        base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);

		GameObject company = Instantiate(imagePrefab, infoPanel.transform);
		company.GetComponent<RectTransform>().anchoredPosition = new Vector2(-260, 160);
		company.GetComponent<RectTransform>().sizeDelta = new Vector2(30, 30);
		company.GetComponent<RawImage>().texture = companyArt;

		GameObject hpText = Instantiate(textPrefab, infoPanel.transform);
		hpText.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 130);
		hpText.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 20);
		hpText.GetComponent<TMP_Text>().text = "HP: " + hp.ToString();

		GameObject defenseText = Instantiate(textPrefab, infoPanel.transform);
		defenseText.GetComponent<RectTransform>().anchoredPosition = new Vector2(240, 130);
		defenseText.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 20);
		defenseText.GetComponent<TMP_Text>().text = "Def: " + defense.ToString();

		if(auxSlots > 0) GenerateSlotText(infoPanel, textPrefab, auxSlots, "Auxiliary");
		if(primSlots > 0) GenerateSlotText(infoPanel, textPrefab, primSlots, "Primary");
		if (sHeavySlots > 0) GenerateSlotText(infoPanel, textPrefab, sHeavySlots, "Super Heavy");
		if (systemSlots > 0) GenerateSlotText(infoPanel, textPrefab, systemSlots, "System");
		if (wingSlots > 0) GenerateSlotText(infoPanel, textPrefab, wingSlots, "Wing");
		if (escortSlots > 0) GenerateSlotText(infoPanel, textPrefab, escortSlots, "Escort");

		GenerateTraitText(infoPanel, textPrefab);

		x = -170;
		y -= longestText + infoPanel.transform.GetChild(3).GetComponent<RectTransform>().sizeDelta.y / 2;
		infoPanel.transform.GetChild(3).GetComponent<RectTransform>().anchoredPosition = new Vector2(-90, y);
	}

	private void GenerateSlotText(GameObject infoPanel, GameObject textPrefab, uint slots, string text)
	{
		GameObject button = Instantiate(textPrefab, infoPanel.transform);
		button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
		button.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 40);
		button.GetComponentInChildren<TMP_Text>().text = text + " Slots: " + slots;

		slotNum++;
		x += 195;
		if (slotNum % 3 == 0)
		{
			x = -195;
			y -= 40;
		}
	}

	private void GenerateTraitText(GameObject infoPanel, GameObject textPrefab)
	{
		x = -170;
		y -= 45;
		longestText = 0f;

		for(int i = 0; i < traits.Count; i++)
		{
			if (i != 0 && i % 2 == 0)
			{
				x = -170;
				y -= longestText;
				longestText = 0f;
			}

			GameObject title = Instantiate(textPrefab, infoPanel.transform);
			title.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			title.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 25);
			title.GetComponent<TMP_Text>().text = traits[i].TraitName;

			GameObject mechText = Instantiate(textPrefab, infoPanel.transform);
			ContentSizeFitter csf = mechText.AddComponent<ContentSizeFitter>();
			csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			mechText.GetComponent<TMP_Text>().text = traits[i].MechanicalText;
			mechText.GetComponent<TMP_Text>().enableAutoSizing = false;
			mechText.GetComponent<TMP_Text>().fontSize = 12;
			Canvas.ForceUpdateCanvases();
			mechText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y - (title.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y) / 2);

			if (mechText.GetComponent<RectTransform>().sizeDelta.y > longestText) longestText = title.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y;

			x += 210;
		}
	}
}
