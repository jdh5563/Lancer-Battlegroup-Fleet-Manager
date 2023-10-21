using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FleetPanel : MonoBehaviour
{
    [SerializeField] private Texture2D baseImage;

    [SerializeField] private Button[] buttons;

    [SerializeField] private GameObject purchasePanel;
    [SerializeField] private GameObject shipDetailsPanel;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Button button in buttons)
        {
			button.onClick.AddListener(DisplaySidebar);
			button.onClick.AddListener(TogglePurchasePanel);
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DisplaySidebar()
    {
		GameObject selectedButton = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        purchasePanel.GetComponent<PurchasePanel>().DisplaySidebar(selectedButton.GetComponentInChildren<TMP_Text>().text.Split(' ')[0]);
	}

    public void UpdateShipView(GameObject shipToAssign)
    {
        Ship ship = shipToAssign.GetComponentInChildren<Ship>();
        RawImage shipArt = shipToAssign.GetComponentInChildren<RawImage>();
		shipArt.texture = ship.ShipArt;
        shipArt.rectTransform.sizeDelta = new Vector2(200, 200 * ship.ShipArt.height / ship.ShipArt.width);
		shipToAssign.GetComponentInChildren<TMP_Text>().text = ship.ComponentName;
        shipToAssign.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(() => DeleteShip(shipToAssign));
        shipToAssign.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(ToggleShipDetailsPanel);
		shipToAssign.transform.GetChild(1).GetComponent<Button>().onClick.RemoveListener(TogglePurchasePanel);
		shipToAssign.transform.GetChild(1).GetComponent<Button>().onClick.RemoveListener(DisplaySidebar);
	}

    private void TogglePurchasePanel()
    {
        purchasePanel.SetActive(true);
	}

    private void ToggleShipDetailsPanel()
    {
        shipDetailsPanel.SetActive(true);

        GameObject selectedButton = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        GameObject shownShip = selectedButton.transform.GetChild(selectedButton.transform.childCount - 1).gameObject;
        shownShip.transform.SetParent(shipDetailsPanel.transform, false);
        shipDetailsPanel.GetComponent<ShipDetailsPanel>().Display(selectedButton, shownShip.GetComponent<Ship>());
	}

    public void DeleteShip(GameObject shipToDestroy)
    {
        int buttonIndex = shipToDestroy.transform.GetSiblingIndex();

		if (buttonIndex < 3)
        {
			shipToDestroy.transform.GetComponentInChildren<TMP_Text>().text = "Frigate Slot";
		}
        else if(buttonIndex < 5)
        {
			shipToDestroy.transform.GetComponentInChildren<TMP_Text>().text = "Carrier Slot";
		}
        else
        {
			shipToDestroy.transform.GetComponentInChildren<TMP_Text>().text = "Battleship Slot";
		}

		shipToDestroy.transform.GetChild(1).GetComponent<Button>().onClick.RemoveListener(ToggleShipDetailsPanel);
		shipToDestroy.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(DisplaySidebar);
		shipToDestroy.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(TogglePurchasePanel);
		shipToDestroy.GetComponentInChildren<RawImage>().texture = baseImage;
        shipToDestroy.GetComponentInChildren<RawImage>().rectTransform.sizeDelta = new Vector2(100, 100);
        bool shipExists = shipToDestroy.transform.GetChild(shipToDestroy.transform.childCount - 1).TryGetComponent(out Ship ship);
		if(shipExists) Destroy(ship.gameObject);
	}
}
