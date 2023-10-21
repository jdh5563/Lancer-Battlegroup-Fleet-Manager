using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class PurchasePanel : MonoBehaviour
{
	[SerializeField] private GameObject header;
	[SerializeField] private GameObject sidePanel;
	[SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject content;
    [SerializeField] private GameObject purchaseButton;
    [SerializeField] private GameObject backButton;

    [SerializeField] private GameObject textPrefab;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject imagePrefab;

    private List<BGComponent> purchasables = new List<BGComponent>();
    private List<BGComponent> filteredList = new List<BGComponent>();

    [SerializeField] private MasterLists masterLists;
    private BGComponent currentComponent = null;
    private GameObject selectedButton = null;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnEnable()
	{
		sidePanel.transform.GetChild(2).GetComponent<Scrollbar>().value = 1;
	}

	private void GenerateButton(BGComponent component)
    {
		GameObject buttonObj = Instantiate(buttonPrefab);

        if (component is Ship)
        {
            int hyphenIndex = component.ComponentName.IndexOf("-");
            buttonObj.GetComponentInChildren<TMP_Text>().text = component.ComponentName.Substring(0, hyphenIndex);
        }
        else
        {
			buttonObj.GetComponentInChildren<TMP_Text>().text = component.ComponentName;
		}

		buttonObj.GetComponent<Button>().onClick.AddListener(() => { DisplayInfo(component); });
		buttonObj.transform.SetParent(content.transform, false);
	}

	public void DisplaySidebar(string componentType)
    {
        selectedButton = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;

        if (selectedButton.transform.parent.name == "Fleet View")
        {
            purchaseButton.GetComponent<Button>().onClick.AddListener(CallUpdateShipView);
			purchaseButton.GetComponent<Button>().onClick.AddListener(EnableFleetPanel);
			backButton.GetComponent<Button>().onClick.AddListener(RemoveFleetFunctionality);
			backButton.GetComponent<Button>().onClick.AddListener(EnableFleetPanel);
		}
        else
        {
            purchaseButton.GetComponent<Button>().onClick.AddListener(CallUpdateShipDetails);
			purchaseButton.GetComponent<Button>().onClick.AddListener(EnableShipDetailsPanel);
			backButton.GetComponent<Button>().onClick.AddListener(RemoveShipDetailsFunctionality);
			backButton.GetComponent<Button>().onClick.AddListener(EnableShipDetailsPanel);
		}

		header.GetComponentInChildren<TMP_Text>().text = componentType;

        for(int i = 0; i < content.transform.childCount; i++)
        {
            Destroy(content.transform.GetChild(i).gameObject);
        }

		for (int i = 0; i < infoPanel.transform.childCount; i++)
		{
			Destroy(infoPanel.transform.GetChild(i).gameObject);
		}

		purchasables.Clear();
        purchasables.AddRange(masterLists.components[componentType]);

        foreach(BGComponent component in purchasables)
        {
            GenerateButton(component);
        }
	}

    public void DisplayInfo(BGComponent component)
    {
		// This will build a bunch of text boxes based on
		// the ship associated with the selected button
        while(infoPanel.transform.childCount > 0)
        {
			DestroyImmediate(infoPanel.transform.GetChild(0).gameObject);
		}
        infoPanel.GetComponent<RectTransform>().sizeDelta = new Vector2(infoPanel.GetComponent<RectTransform>().sizeDelta.x, 360);
        infoPanel.transform.parent.parent.GetChild(2).GetComponent<Scrollbar>().value = 1;

		currentComponent = Instantiate(component.gameObject, infoPanel.transform).GetComponent<BGComponent>();
        currentComponent.Display(infoPanel, textPrefab, buttonPrefab, imagePrefab);

        int originalParentCount = infoPanel.transform.parent.childCount;
        int originalChildCount = infoPanel.transform.childCount;
        RectTransform lowestElement = infoPanel.transform.GetChild(3).GetComponent<RectTransform>();
        float lowestY = lowestElement.anchoredPosition.y;

        while(infoPanel.transform.childCount > 0)
        {
            infoPanel.transform.GetChild(0).SetParent(infoPanel.transform.parent);
        }

        infoPanel.GetComponent<RectTransform>().sizeDelta = new Vector2(infoPanel.GetComponent<RectTransform>().sizeDelta.x, infoPanel.GetComponent<RectTransform>().sizeDelta.y + Mathf.Abs(lowestY + lowestElement.sizeDelta.y / 2));

        int elementIndex = infoPanel.transform.parent.childCount - originalChildCount;
		while (infoPanel.transform.parent.childCount > originalParentCount)
        {
            infoPanel.transform.parent.GetChild(elementIndex).SetParent(infoPanel.transform);
        }
	}

    public void Purchase()
    {
        if (selectedButton.transform.GetChild(selectedButton.transform.childCount - 1).TryGetComponent(out BGComponent ship)) DestroyImmediate(ship.gameObject);
        currentComponent.transform.SetParent(selectedButton.transform, false);
        currentComponent = null;

		if (selectedButton.transform.parent.name == "Fleet View")
		{
            RemoveFleetFunctionality();
		}
		else
		{
            RemoveShipDetailsFunctionality();
		}
	}

    private void CallUpdateShipView()
    {
		selectedButton.transform.parent.GetComponent<FleetPanel>().UpdateShipView(selectedButton);
	}

    private void CallUpdateShipDetails()
    {
        selectedButton.transform.parent.parent.parent.GetComponent<ShipDetailsPanel>().UpdateShipDetails(selectedButton);
    }

    private void EnableFleetPanel()
    {
        selectedButton.transform.parent.gameObject.SetActive(true);
	}

    private void EnableShipDetailsPanel()
    {
		selectedButton.transform.parent.parent.parent.gameObject.SetActive(true);
	}

    private void RemoveFleetFunctionality()
    {
		purchaseButton.GetComponent<Button>().onClick.RemoveListener(CallUpdateShipView);
		purchaseButton.GetComponent<Button>().onClick.RemoveListener(EnableFleetPanel);
		backButton.GetComponent<Button>().onClick.RemoveListener(RemoveFleetFunctionality);
		backButton.GetComponent<Button>().onClick.RemoveListener(EnableFleetPanel);
	}

    private void RemoveShipDetailsFunctionality()
    {
        purchaseButton.GetComponent<Button>().onClick.RemoveListener(CallUpdateShipDetails);
        purchaseButton.GetComponent<Button>().onClick.RemoveListener(EnableShipDetailsPanel);
		backButton.GetComponent<Button>().onClick.RemoveListener(RemoveShipDetailsFunctionality);
		backButton.GetComponent<Button>().onClick.RemoveListener(EnableShipDetailsPanel);
	}
}
