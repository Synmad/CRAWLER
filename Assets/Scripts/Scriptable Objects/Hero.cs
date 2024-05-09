using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero", menuName = "Scriptable Objects/Hero")]
public class Hero : ScriptableObject
{
    [field:SerializeField] public List<Skill> Skills { get; private set; } = new(); 
}
