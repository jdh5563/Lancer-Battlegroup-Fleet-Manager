using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MiscData
{
	public static uint NO_RANGE = 100;
	public static int NO_HP = 100;
	public static string CASPIAN_FLAVOR = "The GMS Caspian Sea is the backbone of Union's fleets. Built upon a base pattern outfitted with overlapping primary and secondary batteries, Caspian Sea-class frigates are tough and flexible multirole vessels that can hold their own both in a battle line and on solo patrol. Developed by GMS under the Second Committee during the Second Expansion Period, the Caspian Sea class has been in use for centuries thanks to ongoing platform modernization regimes. It was one of the few hulls not to be scrapped during the Third Committee's ground-up reworking of the Union Naval Department, and these frigates remain a common first posting for both regular and auxiliary navy personnel. Union naval doctrine typically designates Caspian Sea-class frigates as fire-coordination platforms and \"mainline\"-tier ships of the line.";
	public static string FCN_TEXT = "1/round when an allied battlegroup in your range band consumes Lock On as part of an attack, it may reroll that attack but must keep the second result.\r\nAdditionally, when this ship is assigned to a Defensive Screen, it may Lock On to a hostile Capital Ship or Escort.";

	public static string HURON_FLAVOR = "The Huron-class frigate is a dedicated weapons platform most often stationed at the perimeters of friendly fleets, where it patrols the flanks as a deterrent to hostile fighters and subline ships. Able to distribute withering curtains of fire along multiple approach vectors, Huron-class frigates are stalwart defensive support units rarely encountered outside of combat deployments. In the Union Navy, there's an old axiom: \"If you can see a Huron, prepare for a storm.\"";
	public static string FLAK_SCREEN_TEXT = "Whenever a hostile Escort or Wing makes an attack roll against or deals damage to any of your Capital Ships, Escorts, or Wings during the Action Phase, roll 1d20.\r\nOn 10+, the attacker first takes 3 damage. If this damage is enough to destroy it, it is destroyed before it can carry out its attack or action and any effects are negated.\r\nWhen this Frigate is assigned to a Defensive Screen, this trait applies to the battlegroup it is screening for and the roll automatically succeeds.\r\nThis trait does not stack. Instead, whenever multiple ships with this trait are part of or are screening the same battlegroup, choose one to use this trait and increase its damage by + 1 for each additional ship with this trait beyond the first.";
}
