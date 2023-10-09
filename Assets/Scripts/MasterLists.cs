using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ComponentType
{
	Frigate,
	Carrier,
	Battleship,
	System
}

[CreateAssetMenu(fileName = "MasterLists", menuName = "ScriptableObjects/MasterLists", order = 1)]
public class MasterLists : ScriptableObject
{
	public Dictionary<ComponentType, List<BGComponent>> components = new Dictionary<ComponentType, List<BGComponent>>();

	[SerializeField] private List<BGComponent> frigates;
	[SerializeField] private List<BGComponent> carriers;
	[SerializeField] private List<BGComponent> battleships;
	[SerializeField] private List<BGComponent> systems;

	private void OnEnable()
	{
		components.Add(ComponentType.Frigate, frigates);
		components.Add(ComponentType.Carrier, carriers);
		components.Add(ComponentType.Battleship, battleships);
		components.Add(ComponentType.System, systems);
	}
}
