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

    public void Display(string componentType)
    {
        purchasables.Clear();
        purchasables.AddRange(masterLists.components[componentType]);

        for(int i = 0; i < purchasables.Count; i++)
        {
            GameObject buttonObj = purchasables[i].GenerateButton();
            buttonObj.transform.SetParent(content.transform, false);
        }
    }
}
