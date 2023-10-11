using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CaspianSea : Ship
{
	private void Awake()
	{
		flavorText = MiscData.CASPIAN_FLAVOR;
	}

	// Start is called before the first frame update
	protected override void Start()
    {
        base.Start();
		traits.Add(new FireControlNetworking());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab);

		GameObject primButton = Instantiate(buttonPrefab, infoPanel.transform);
		primButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-195, 75);
		primButton.GetComponent<RectTransform>().sizeDelta = new Vector2(150, 40);
		primButton.GetComponentInChildren<TMP_Text>().text = "Primary Weapon";

		GameObject auxButton = Instantiate(buttonPrefab, infoPanel.transform);
		auxButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-30, 75);
		auxButton.GetComponent<RectTransform>().sizeDelta = new Vector2(150, 40);
		auxButton.GetComponentInChildren<TMP_Text>().text = "Auxiliary Weapon";
	}

	class FireControlNetworking : Trait
	{
		public FireControlNetworking()
		{
			traitName = "Fire Control Networking";
			mechanicalText = MiscData.FCN_TEXT;
		}
	}
}
