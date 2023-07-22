using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SoAbsAbility : ScriptableObject
{
    public string AbilityName = "Ability Name";
    public int Damage = 10;
    public int ManaRequired = 10;
    public abstract void UseAbility();
}
