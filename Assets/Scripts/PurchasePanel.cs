using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchasePanel : MonoBehaviour
{
	[SerializeField] private GameObject header;
	[SerializeField] private GameObject sidePanel;
	[SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject content;

    private List<BGComponent> purchasables = new List<BGComponent>();
    private List<BGComponent> filteredList = new List<BGComponent>();

    [SerializeField] private MasterLists masterLists;

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

    public void DisplaySidebar(string componentType)
    {
        purchasables.Clear();
        purchasables.AddRange(masterLists.components[componentType]);

        foreach(BGComponent component in purchasables)
        {
			GameObject buttonObj = component.GenerateButton();
			buttonObj.GetComponent<Button>().onClick.AddListener(() => { DisplayInfo(component); });
            buttonObj.transform.SetParent(content.transform, false);
        }
    }

    public void DisplayInfo(BGComponent component)
    {
        // This will build a bunch of text boxes and whatnot
        // based on the ship associated with the selected button
        component.Display();
	}
}
