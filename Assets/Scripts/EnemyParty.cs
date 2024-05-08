using System.Collections.Generic;
using UnityEngine;

public class EnemyParty : MonoBehaviour
{
    [field: SerializeField] public List<Enemy> Enemies { get; private set; } = new();
}
