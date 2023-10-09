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

    public Action()
    {
        tags = new Dictionary<Tag, int>();
    }

    public virtual void Display()
    {

    }
}
