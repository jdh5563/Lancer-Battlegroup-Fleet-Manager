using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MasterLists", menuName = "ScriptableObjects/MasterLists", order = 1)]
public class MasterLists : ScriptableObject
{
	public Dictionary<string, List<BGComponent>> components = new Dictionary<string, List<BGComponent>>();

	[SerializeField] private List<BGComponent> frigates;
	[SerializeField] private List<BGComponent> carriers;
	[SerializeField] private List<BGComponent> battleships;
	[SerializeField] private List<BGComponent> systems;
	[SerializeField] private List<BGComponent> auxWeapons;
	[SerializeField] private List<BGComponent> primWeapons;
	[SerializeField] private List<BGComponent> sHeavyWeapons;
	[SerializeField] private List<BGComponent> wings;
	[SerializeField] private List<BGComponent> escorts;

	private void OnEnable()
	{
		components.Add("Frigate", frigates);
		components.Add("Carrier", carriers);
		components.Add("Battleship", battleships);
		components.Add("System", systems);
		components.Add("Auxiliary Weapon", auxWeapons);
		components.Add("Primary Weapon", primWeapons);
		components.Add("Super Heavy Weapon", sHeavyWeapons);
		components.Add("Wing", wings);
		components.Add("Escort", escorts);
	}
}
