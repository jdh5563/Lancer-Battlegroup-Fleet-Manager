using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipSystem : BGComponent
{
	[SerializeField] protected Dictionary<Tag, int> tags;
    [SerializeField] protected List<Action> actions;
    [SerializeField] protected string mechanicalText;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        actions = new List<Action>();
        tags = new Dictionary<Tag, int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{

	}
}
