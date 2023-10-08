using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tactic : MonoBehaviour
{
    [SerializeField] protected string tacticName;
    [SerializeField] protected string mechanicalText;
	[SerializeField] protected uint minRange;
	[SerializeField] protected uint maxRange;
	[SerializeField] protected Dictionary<string, int> tags;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
