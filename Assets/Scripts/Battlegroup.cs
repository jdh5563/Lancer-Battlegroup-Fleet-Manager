using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlegroup : MonoBehaviour
{
	[SerializeField] private string groupName;
    [SerializeField] private string description;
    [SerializeField] private int maxPoints;
    [SerializeField] private int currentPoints;
    [SerializeField] private List<Log> playerLogs;
	[SerializeField] private List<Frigate> frigates;
    [SerializeField] private List<Carrier> carriers;
    [SerializeField] private List<Battleship> battleships;
    [SerializeField] private Commander commander;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
