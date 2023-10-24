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

    //protected GameObject keyInfoLayout = null;

    public string ComponentName
    {
        get { return componentName; }
    }

	protected virtual void Awake()
	{

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
  //      keyInfoLayout = new GameObject();
  //      keyInfoLayout.transform.parent = infoPanel.transform;
		//VerticalLayoutGroup vlg = keyInfoLayout.AddComponent<VerticalLayoutGroup>();
  //      keyInfoLayout.GetComponent<RectTransform>().anchoredPosition = new Vector2(192, 50);
  //      keyInfoLayout.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 50);
  //      vlg.spacing = 44.5f;
		//vlg.childControlHeight = true;
		//vlg.childControlWidth = false;
  //      vlg.childForceExpandHeight = false;
  //      vlg.childForceExpandWidth = false;
  //      vlg.childScaleHeight = false;
  //      vlg.childScaleWidth = false;

		GameObject nameText = Instantiate(textPrefab, infoPanel.transform);
		nameText.GetComponent<RectTransform>().anchoredPosition = new Vector2(-40, 160);
		nameText.GetComponent<RectTransform>().sizeDelta = new Vector2(375, 25);
		nameText.GetComponent<TMP_Text>().text = componentName;

		GameObject pointText = Instantiate(textPrefab, infoPanel.transform);
		pointText.GetComponent<RectTransform>().anchoredPosition = new Vector2(200, 160);
		pointText.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 25);
		pointText.GetComponent<TMP_Text>().text = "Point Cost: " + pointCost.ToString();

        GameObject flavText = Instantiate(textPrefab, infoPanel.transform);
        flavText.GetComponent<RectTransform>().sizeDelta = new Vector2(360, 180);
        flavText.GetComponent<TMP_Text>().text = flavorText;
	}
}
