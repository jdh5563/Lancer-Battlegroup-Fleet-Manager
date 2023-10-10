using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSystem : BGComponent
{
	[SerializeField] protected Dictionary<string, int> tags;
    [SerializeField] protected List<Action> actions;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab)
	{

	}
}
