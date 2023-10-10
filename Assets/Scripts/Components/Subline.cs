using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subline : BGComponent
{
    [SerializeField] protected bool isWing;
	[SerializeField] protected Dictionary<string, int> tags;
	[SerializeField] protected List<Action> tactics;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel)
	{

	}
}
