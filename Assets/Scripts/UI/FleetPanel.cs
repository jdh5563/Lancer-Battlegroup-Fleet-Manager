using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FleetPanel : MonoBehaviour
{
    [SerializeField] private Texture2D baseImage;
	private string baseText = "No Ship Purchased";

	[SerializeField] private List<GameObject> buttons;

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchShip(int direction)
    {
        buttons[currentIndex].SetActive(false);

        currentIndex = (currentIndex + direction) % buttons.Count;
        if(currentIndex < 0) currentIndex = buttons.Count - 1;

        buttons[currentIndex].SetActive(true);
    }

    public void UpdateShipView(GameObject shipToAssign)
    {
        Ship ship = shipToAssign.GetComponentInChildren<Ship>();
        RawImage shipArt = shipToAssign.GetComponentInChildren<RawImage>();
		shipArt.texture = ship.ShipArt;
        shipArt.rectTransform.sizeDelta = new Vector2(100, 100 * ship.ShipArt.height / ship.ShipArt.width);
		shipToAssign.GetComponentInChildren<TMP_Text>().text = ship.ComponentName;
		shipToAssign.transform.GetChild(1).gameObject.SetActive(false);
		shipToAssign.transform.GetChild(2).gameObject.SetActive(true);
		shipToAssign.transform.GetChild(3).gameObject.SetActive(true);
	}

    public void DeleteShip(GameObject shipToDestroy)
    {
        shipToDestroy.transform.GetComponentInChildren<TMP_Text>().text = baseText;
        shipToDestroy.GetComponentInChildren<RawImage>().texture = baseImage;
        shipToDestroy.GetComponentInChildren<RawImage>().rectTransform.sizeDelta = new Vector2(100, 100);
		Destroy(shipToDestroy.transform.GetChild(shipToDestroy.transform.childCount - 1).gameObject);
		shipToDestroy.transform.GetChild(1).gameObject.SetActive(true);
		shipToDestroy.transform.GetChild(2).gameObject.SetActive(false);
		shipToDestroy.transform.GetChild(3).gameObject.SetActive(false);
	}
}
