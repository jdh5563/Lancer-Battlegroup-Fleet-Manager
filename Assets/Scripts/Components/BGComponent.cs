using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public enum Tag
{
    Unique,
    Limited,
    Reloading,
    Legionspace,
    Reliable,
    Critical,
    Accurate,
    Overkill,
    Payload,
    Boarding,
    Charge
}

public abstract class BGComponent : MonoBehaviour
{
    [SerializeField] protected string componentName;
    [SerializeField] protected string flavorText;
	[SerializeField] protected uint pointCost;

    public string ComponentName
    {
        get { return componentName; }
    }

	// Start is called before the first frame update
	protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
    {
		GameObject nameText = Instantiate(textPrefab, infoPanel.transform);
		nameText.GetComponent<RectTransform>().anchoredPosition = new Vector2(-60, 160);
		nameText.GetComponent<RectTransform>().sizeDelta = new Vector2(375, 25);
		nameText.GetComponent<TMP_Text>().text = componentName;

		GameObject pointText = Instantiate(textPrefab, infoPanel.transform);
		pointText.GetComponent<RectTransform>().anchoredPosition = new Vector2(210, 160);
		pointText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 25);
		pointText.GetComponent<TMP_Text>().text = "Point Cost: " + pointCost.ToString();

		GameObject flavText = Instantiate(textPrefab, infoPanel.transform);
		flavText.GetComponent<RectTransform>().anchoredPosition = new Vector2(-90, -70);
		flavText.GetComponent<RectTransform>().sizeDelta = new Vector2(360, 180);
		flavText.GetComponent<TMP_Text>().text = flavorText;
	}
}
