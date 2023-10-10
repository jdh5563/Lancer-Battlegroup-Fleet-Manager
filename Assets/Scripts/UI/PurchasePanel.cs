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

    [SerializeField] private GameObject textPrefab;
    [SerializeField] private GameObject buttonPrefab;

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

    private void GenerateButton(BGComponent component)
    {
		GameObject buttonObj = Instantiate(buttonPrefab);
		buttonObj.GetComponentInChildren<TMP_Text>().text = component.ComponentName;
		buttonObj.GetComponent<Button>().onClick.AddListener(() => { DisplayInfo(component); });
		buttonObj.transform.SetParent(content.transform, false);
	}

	public void DisplaySidebar(string componentType)
    {
        selectedButton = EventSystem.current.currentSelectedGameObject;
        header.GetComponentInChildren<TMP_Text>().text = componentType;

        for(int i = 0; i < content.transform.childCount; i++)
        {
            Destroy(content.transform.GetChild(i).gameObject);
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
        // This will build a bunch of text boxes and whatnot
        // based on the ship associated with the selected button
        for(int i = 1; i < infoPanel.transform.childCount; i++)
        {
            Destroy(infoPanel.transform.GetChild(i).gameObject);
        }

        currentComponent = Instantiate(component.gameObject, infoPanel.transform).GetComponent<BGComponent>();
        currentComponent.Display(infoPanel, textPrefab, buttonPrefab);
	}

    public void Purchase()
    {
        if (selectedButton.transform.GetChild(selectedButton.transform.childCount - 1).TryGetComponent(out BGComponent ship)) DestroyImmediate(ship.gameObject);
        currentComponent.transform.SetParent(selectedButton.transform, false);
        currentComponent = null;
    }
}
