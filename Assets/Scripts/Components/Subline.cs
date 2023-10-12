using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Subline : BGComponent
{
    [SerializeField] protected bool isWing;
	[SerializeField] protected Dictionary<Tag, int> tags;
	[SerializeField] protected List<Action> tactics;
    [SerializeField] protected string mechanicalText;
    [SerializeField] protected uint minRange;
    [SerializeField] protected uint maxRange;
    [SerializeField] protected int hp;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        tags = new Dictionary<Tag, int>();
        tactics = new List<Action>();
        isWing = false;
        mechanicalText = "";
        minRange = MiscData.NO_RANGE;
        maxRange = MiscData.NO_RANGE;
        hp = MiscData.NO_HP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Display(GameObject infoPanel, GameObject textPrefab, GameObject buttonPrefab, GameObject imagePrefab)
	{

	}
}
