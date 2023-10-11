using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FleetPanel : MonoBehaviour
{
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
    }
}
