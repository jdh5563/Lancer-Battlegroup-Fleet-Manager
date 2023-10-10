using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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

    public string ComponentName
    {
        get { return componentName; }
    }

	// Start is called before the first frame update
	protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Display(GameObject infoPanel);
}
