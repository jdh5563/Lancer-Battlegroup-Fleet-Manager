using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
