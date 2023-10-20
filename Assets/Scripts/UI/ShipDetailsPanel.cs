using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShipDetailsPanel : MonoBehaviour
{
    [SerializeField] private GameObject fleetPanel;
    [SerializeField] private GameObject header;
    [SerializeField] private GameObject info;
    [SerializeField] private GameObject backButton;

    [SerializeField] private GameObject textPrefab;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject imagePrefab;

    private GameObject selectedButton = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupFleetMenu()
    {
		transform.GetChild(transform.childCount - 1).SetParent(selectedButton.transform, false);
        selectedButton = null;
	}

    public void Display(GameObject selectedButton, Ship ship)
    {
        this.selectedButton = selectedButton;
        header.transform.GetChild(0).GetComponent<TMP_Text>().text = ship.ComponentName;

		while (info.transform.childCount > 0)
		{
			DestroyImmediate(info.transform.GetChild(0).gameObject);
		}
		info.GetComponent<RectTransform>().sizeDelta = new Vector2(info.GetComponent<RectTransform>().sizeDelta.x, 300);
		info.transform.parent.parent.GetChild(2).GetComponent<Scrollbar>().value = 1;

        ship.DisplayUpgrades(info, textPrefab, buttonPrefab, imagePrefab);
	}
}
