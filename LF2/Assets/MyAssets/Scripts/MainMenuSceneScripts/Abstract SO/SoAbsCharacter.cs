using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Character")]
public abstract class SoAbsCharacter : ScriptableObject
{
    public string CharacterName = "Character Name";
    public int HP = 100;
    public int Mana = 100;
    // public List<Ability> CharacterAbility;



}
