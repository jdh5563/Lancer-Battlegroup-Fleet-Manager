using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class PrimaryWeapon : Weapon
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
        //isSingleTarget = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
    {
        base.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);

        x = rangeText.GetComponent<RectTransform>().anchoredPosition.x;
        y = rangeText.GetComponent<RectTransform>().anchoredPosition.y - rangeText.GetComponent<RectTransform>().sizeDelta.y / 2f - 20f;

        GameObject targetText = Instantiate(textPrefab, infoPanel.transform);
        targetText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
		targetText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 25);
        targetText.GetComponent<TMP_Text>().text = isSingleTarget ? "Single" : "Area" + "-Target";

		y -= targetText.GetComponent<RectTransform>().sizeDelta.y / 2f + 20f;

        GameObject damageText = Instantiate(textPrefab, infoPanel.transform);
		damageText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
		damageText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 25);
		damageText.GetComponent<TMP_Text>().text = "";
		damageText.GetComponent<TMP_Text>().text += damage[0] == 0 ? "" : damage[0].ToString() + "d6+";
		damageText.GetComponent<TMP_Text>().text += damage[1] == 0 ? "" : damage[1].ToString() + "d3+";
		damageText.GetComponent<TMP_Text>().text += damage[2] == 0 ? "" : damage[2].ToString();
		damageText.GetComponent<TMP_Text>().text = damageText.GetComponent<TMP_Text>().text.TrimEnd('+') + " damage";

		y -= damageText.GetComponent<RectTransform>().sizeDelta.y / 2f + 20f;

		GameObject tagText = Instantiate(textPrefab, infoPanel.transform);
		tagText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 25);
		ContentSizeFitter csf = tagText.AddComponent<ContentSizeFitter>();
		csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

		tagText.GetComponent<TMP_Text>().text = "";
		foreach (Tag tag in tags.Keys)
		{
			tagText.GetComponent<TMP_Text>().text += tag.ToString() + (tags[tag] != 0 ? " " + tags[tag].ToString() : "") + ", ";
		}
		tagText.GetComponent<TMP_Text>().text = tagText.GetComponent<TMP_Text>().text.TrimEnd(',', ' ');

		tagText.GetComponent<TMP_Text>().enableAutoSizing = false;
		tagText.GetComponent<TMP_Text>().fontSize = 22.35f;
		Canvas.ForceUpdateCanvases();
		y -= tagText.GetComponent<RectTransform>().sizeDelta.y / 2 - 20f;
		tagText.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
	}
}
