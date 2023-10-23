using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;
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
	private float x = -175;
	private float y = 85;
	private float longestText = 0f;

	private GameObject purchasePanel;
	private GameObject shipDetailsPanel;

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
		purchasePanel = GameObject.Find("Purchase");
		shipDetailsPanel = purchasePanel.transform.parent.GetChild(purchasePanel.transform.GetSiblingIndex() + 1).gameObject;
		//auxSlots = 0;
		//primSlots = 0;
		//sHeavySlots = 0;
		//systemSlots = 0;
		//wingSlots = 0;
		//escortSlots = 0;
	}

	// Update is called once per frame
	void Update()
    {
        
    }

    public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
    {
        base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);

		slotNum = 0;

		GameObject company = Instantiate(imagePrefab, infoPanel.transform);
		company.GetComponent<RectTransform>().anchoredPosition = new Vector2(-250, 160);
		company.GetComponent<RectTransform>().sizeDelta = new Vector2(30, 30);
		company.GetComponent<RawImage>().texture = companyArt;

		GameObject hpText = Instantiate(textPrefab, infoPanel.transform);
		hpText.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 130);
		hpText.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 20);
		hpText.GetComponent<TMP_Text>().text = "HP: " + hp.ToString();

		GameObject defenseText = Instantiate(textPrefab, infoPanel.transform);
		defenseText.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, 130);
		defenseText.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 20);
		defenseText.GetComponent<TMP_Text>().text = "Def: " + defense.ToString();

		if(auxSlots > 0) GenerateSlotText(infoPanel, textPrefab, auxSlots, "Auxiliary");
		if(primSlots > 0) GenerateSlotText(infoPanel, textPrefab, primSlots, "Primary");
		if (sHeavySlots > 0) GenerateSlotText(infoPanel, textPrefab, sHeavySlots, "Super Heavy");
		if (systemSlots > 0) GenerateSlotText(infoPanel, textPrefab, systemSlots, "System");
		if (wingSlots > 0) GenerateSlotText(infoPanel, textPrefab, wingSlots, "Wing");
		if (escortSlots > 0) GenerateSlotText(infoPanel, textPrefab, escortSlots, "Escort");

		if (slotNum % 2 == 0) y += 40;

		if(traits.Count > 0) GenerateTraitText(infoPanel, textPrefab);
		if(actions.Count > 0) GenerateActionText(infoPanel, textPrefab);

		y -= 25 + infoPanel.transform.GetChild(3).GetComponent<RectTransform>().sizeDelta.y / 2;
		infoPanel.transform.GetChild(3).GetComponent<RectTransform>().anchoredPosition = new Vector2(-80, y);
	}

	public void DisplayUpgrades(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{
		slotNum = 0;
		x = -175;
		y = 110;

		if (auxSlots > 0) GenerateUpgradeButton(infoPanel, textPrefab, buttonPrefab, "Auxiliary", auxSlots);
		if (primSlots > 0) GenerateUpgradeButton(infoPanel, textPrefab, buttonPrefab, "Primary", primSlots);
		if (sHeavySlots > 0) GenerateUpgradeButton(infoPanel, textPrefab, buttonPrefab, "Super Heavy", sHeavySlots);
		if (systemSlots > 0) GenerateUpgradeButton(infoPanel, textPrefab, buttonPrefab, "System", systemSlots);
		if (wingSlots > 0) GenerateUpgradeButton(infoPanel, textPrefab, buttonPrefab, "Wing", wingSlots);
		if (escortSlots > 0) GenerateUpgradeButton(infoPanel, textPrefab, buttonPrefab, "Escort", escortSlots);
	}

	private void GenerateSlotText(GameObject infoPanel, GameObject textPrefab, uint slots, string text)
	{
		GameObject button = Instantiate(textPrefab, infoPanel.transform);
		button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
		button.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 40);
		button.GetComponentInChildren<TMP_Text>().text = text + " Slots: " + slots;

		slotNum++;
		x += 195;
		if (slotNum % 2 == 0)
		{
			x = -175;
			y -= 40;
		}
	}

	private void GenerateUpgradeButton(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, string componentType, uint numSlots)
	{
		float originalX = x;
		float originalY = y;

		GameObject text = Instantiate(textPrefab, infoPanel.transform);
		text.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
		text.GetComponent<RectTransform>().sizeDelta = new Vector2(350, 50);
		text.GetComponentInChildren<TMP_Text>().text = componentType;

		x -= 100;
		y -= 60;

		for (int i = 1; i <= numSlots; i++)
		{
			GameObject button = Instantiate(buttonPrefab, infoPanel.transform);
			button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			button.GetComponent<RectTransform>().sizeDelta = new Vector2(150, 50);
			button.GetComponentInChildren<TMP_Text>().text = "No " + componentType + " Installed";

			button.GetComponent<Button>().onClick.AddListener(() => purchasePanel.GetComponent<PurchasePanel>().DisplaySidebar(componentType));
			button.GetComponent<Button>().onClick.AddListener(() => purchasePanel.SetActive(true));
			button.GetComponent<Button>().onClick.AddListener(() => shipDetailsPanel.SetActive(false));

			x += 175;
			if (i % 2 == 0)
			{
				x -= 350;
				y -= 75;
			}
		}

		x = originalX;
		y = originalY;

		slotNum++;
		if (slotNum % 2 == 0)
		{
			x = -175;
			y -= 190;
		}
		else
		{
			x += 375;
		}
	}

	private void GenerateTraitText(GameObject infoPanel, GameObject textPrefab)
	{
		x = -160;
		y -= 45;
		longestText = 0f;
		float originalY = y;

		for(int i = 0; i < traits.Count; i++)
		{
			if (i != 0 && i % 2 == 0)
			{
				x = -160;
				y -= longestText;
				longestText = 0f;
				originalY = y;
			}

			GameObject title = Instantiate(textPrefab, infoPanel.transform);
			title.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			title.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 25);
			title.GetComponent<TMP_Text>().text = traits[i].TraitName;

			y -= title.GetComponent<RectTransform>().sizeDelta.y / 1.5f;

			GameObject traitText = Instantiate(textPrefab, infoPanel.transform);
			traitText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			traitText.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 15);
			traitText.GetComponent<TMP_Text>().text = "Trait";

			if (this is Houston ship) ship.AddTraitTag(traitText);

			GameObject mechText = Instantiate(textPrefab, infoPanel.transform);
			ContentSizeFitter csf = mechText.AddComponent<ContentSizeFitter>();
			csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			mechText.GetComponent<TMP_Text>().text = traits[i].MechanicalText;
			mechText.GetComponent<TMP_Text>().enableAutoSizing = false;
			mechText.GetComponent<TMP_Text>().fontSize = 12;
			Canvas.ForceUpdateCanvases();
			y -= (title.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y) / 2;
			mechText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);

			if (mechText.GetComponent<RectTransform>().sizeDelta.y > longestText) longestText = title.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y;

			x += 210;
			y = originalY;
		}

		y -= longestText;
	}

	private void GenerateActionText(GameObject infoPanel, GameObject textPrefab)
	{
		x = -160;
		y -= 45;
		float originalY = y;

		for (int i = 0; i < actions.Count; i++)
		{
			if (i != 0 && i % 2 == 0)
			{
				x = -160;
				y -= longestText;
				longestText = 0f;
				originalY = y;
			}

			GameObject title = Instantiate(textPrefab, infoPanel.transform);
			title.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			title.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 25);
			title.GetComponent<TMP_Text>().text = actions[i].ActionName;

			y -= title.GetComponent<RectTransform>().sizeDelta.y / 1.5f;

			GameObject actionText = Instantiate(textPrefab, infoPanel.transform);
			actionText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			actionText.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 15);
			actionText.GetComponent<TMP_Text>().text = actions[i].IsTactic ? "Tactic" : "Maneuver";
			foreach(Tag tag in actions[i].Tags.Keys)
			{
				actionText.GetComponent<TMP_Text>().text += ", " + tag.ToString() + " " + actions[i].Tags[tag].ToString();
			}

			GameObject mechText = Instantiate(textPrefab, infoPanel.transform);
			ContentSizeFitter csf = mechText.AddComponent<ContentSizeFitter>();
			csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			mechText.GetComponent<TMP_Text>().text = actions[i].MechanicalText;
			mechText.GetComponent<TMP_Text>().enableAutoSizing = false;
			mechText.GetComponent<TMP_Text>().fontSize = 12;
			Canvas.ForceUpdateCanvases();
			y -= (title.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y) / 2;
			mechText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);

			if (mechText.GetComponent<RectTransform>().sizeDelta.y > longestText) longestText = title.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y;

			x += 210;
			y = originalY;
		}

		y -= longestText;
	}
}
