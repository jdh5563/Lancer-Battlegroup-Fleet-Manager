using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePanel : MonoBehaviour
{
	[SerializeField] private GameObject header;
	[SerializeField] private GameObject sidePanel;
	[SerializeField] private GameObject infoPanel;

    private List<BGComponent> purchasables = new List<BGComponent>();
    private List<BGComponent> filteredList = new List<BGComponent>();

    public List<BGComponent> Purchasables
    {
        get { return purchasables; }

        set { purchasables.AddRange(value); }
    }

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Display(List<BGComponent> purchasables)
    {
        infoPanel.SetActive(true);
        this.purchasables = purchasables;
    }
}
