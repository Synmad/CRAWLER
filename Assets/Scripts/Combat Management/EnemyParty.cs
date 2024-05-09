using System.Collections.Generic;
using UnityEngine;

public class EnemyParty : MonoBehaviour
{
    [field: SerializeField] public List<EnemyController> Enemies { get; private set; } = new();
}
