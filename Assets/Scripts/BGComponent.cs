using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Tag
{
    Unique,
    Limited,
    Reloading,
    Legionspace,
    Reliable,
    Critical,
    Accurate,
    Overkill,
    Payload,
    Boarding,
    Charge
}

public abstract class BGComponent : MonoBehaviour
{
    [SerializeField] protected string componentName;
    [SerializeField] protected string flavorText;
	[SerializeField] protected uint pointCost;

    [SerializeField] protected GameObject buttonPrefab;

	// Start is called before the first frame update
	protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Display();

    public GameObject GenerateButton()
    {
        GameObject buttonObj = Instantiate(buttonPrefab);
		buttonObj.GetComponentInChildren<TMP_Text>().text = componentName;
		buttonObj.GetComponent<Button>().onClick.AddListener(Display);
        return buttonObj;
    }
}
