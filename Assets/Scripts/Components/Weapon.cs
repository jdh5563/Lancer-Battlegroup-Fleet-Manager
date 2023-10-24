using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Weapon : BGComponent
{
	[SerializeField] protected string mechanicalText;
	[SerializeField] protected uint minRange;
	[SerializeField] protected uint maxRange;

	protected GameObject rangeText = null;
	protected float x = 0;
	protected float y = 0;

    // Start is called before the first frame update
    protected override void Start()
    {
		mechanicalText = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	/*
	 SPINAL LINAC COHERENT BEAM CANNON


Superheavy, Single-Target, Charge 2, Critical
[Range 4-1][8 damage][2 points]


An old workhorse, the linear accelerator
coherent beam cannon once marked the
pinnacle of energy weapon development.
Reliable at middle-confidence ranges and,

with modern power systems, capable of rapid-
cycling main battery fire, a LinAc CBC is a

formidable weapon favored by captains who
prefer more traditional strategies.
	 */

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{
		base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);

		GameObject nameDisplay = infoPanel.transform.GetChild(1).gameObject;
		nameDisplay.GetComponent<RectTransform>().anchoredPosition = new Vector2(nameDisplay.GetComponent<RectTransform>().anchoredPosition.x - 35f, nameDisplay.GetComponent<RectTransform>().anchoredPosition.y);

		GameObject pointCostDisplay = infoPanel.transform.GetChild(2).gameObject;
		x = pointCostDisplay.GetComponent<RectTransform>().anchoredPosition.x;
		y = pointCostDisplay.GetComponent<RectTransform>().anchoredPosition.y - pointCostDisplay.GetComponent<RectTransform>().sizeDelta.y / 2 - 20f;

		rangeText = Instantiate(textPrefab, infoPanel.transform);
		rangeText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
		rangeText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 25);
		rangeText.GetComponent<TMP_Text>().text = "Range " + maxRange + "-" + minRange;

		x = nameDisplay.GetComponent<RectTransform>().anchoredPosition.x;
		y = nameDisplay.GetComponent<RectTransform>().anchoredPosition.y - nameDisplay.GetComponent<RectTransform>().sizeDelta.y / 2 - 10f;

		GameObject mechText = Instantiate(textPrefab, infoPanel.transform);
		mechText.GetComponent<RectTransform>().sizeDelta = new Vector2(nameDisplay.GetComponent<RectTransform>().sizeDelta.x, 0);
		ContentSizeFitter csf = mechText.AddComponent<ContentSizeFitter>();
		csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		mechText.GetComponent<TMP_Text>().text = mechanicalText;
		mechText.GetComponent<TMP_Text>().enableAutoSizing = false;
		mechText.GetComponent<TMP_Text>().fontSize = 12;
		Canvas.ForceUpdateCanvases();
		y -= mechText.GetComponent<RectTransform>().sizeDelta.y / 2;
		mechText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);

		// This should be modified to move the flavor text to a more fitting position
		GameObject flavTextDisplay = infoPanel.transform.GetChild(3).gameObject;
		y -= (flavTextDisplay.GetComponent<RectTransform>().sizeDelta.y + mechText.GetComponent<RectTransform>().sizeDelta.y) / 2 + 10f;
		infoPanel.transform.GetChild(3).GetComponent<RectTransform>().anchoredPosition = new Vector2(-80, y);
	}
}
