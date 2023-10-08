using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BGComponent : MonoBehaviour
{
    [SerializeField] protected string componentName;
    [SerializeField] protected string flavorText;
	[SerializeField] protected uint pointCost;

	// Start is called before the first frame update
	protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected abstract void Display();

    public virtual void GenerateButton()
    {

    }
}
