using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{
    protected string actionName;
    protected string mechanicalText;
    protected bool isTactic;
    protected uint minRange;
    protected uint maxRange;
    protected Dictionary<Tag, int> tags;

    public string ActionName
    {
        get { return actionName; }
    }

    public string MechanicalText
    {
        get { return mechanicalText; }
    }

    public bool IsTactic
    {
        get { return isTactic; }
    }

    public uint MinRange
    {
        get { return minRange; }
    }

    public uint MaxRange
    {
        get { return maxRange; }
    }

    public Dictionary<Tag, int> Tags
    {
        get { return tags; }
    }

    public Action()
    {
        isTactic = true;
        minRange = MiscData.NO_RANGE;
        maxRange = MiscData.NO_RANGE;
        tags = new Dictionary<Tag, int>();
    }

    public virtual void Display()
    {

    }
}
