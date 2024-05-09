using System.Collections.Generic;
using UnityEngine;

public class CombatUnit : MonoBehaviour
{
   [field:SerializeField] public int Initiative {get; private set;}

   [field:SerializeField] public List<Skill> Skills { get; protected set; } = new();
}
