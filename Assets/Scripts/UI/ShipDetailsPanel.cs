using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipDetailsPanel : MonoBehaviour
{
    [SerializeField] private GameObject fleetPanel;
    [SerializeField] private GameObject header;
    [SerializeField] private GameObject info;
    [SerializeField] private GameObject backButton;

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

    public void Display(GameObject selectedButton, GameObject ship)
    {
        this.selectedButton = selectedButton;
        header.transform.GetChild(0).GetComponent<TMP_Text>().text = ship.GetComponent<Ship>().ComponentName;
	}
}
