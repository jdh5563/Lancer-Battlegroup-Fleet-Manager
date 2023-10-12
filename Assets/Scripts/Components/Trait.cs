using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public abstract class Trait
{
    protected string traitName;
    protected string mechanicalText;

    public string TraitName
    {
        get { return traitName; }
    }

    public string MechanicalText
    {
        get { return mechanicalText; }
    }

    public virtual void Display()
    {

    }
}
