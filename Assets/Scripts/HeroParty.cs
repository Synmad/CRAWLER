using System.Collections.Generic;
using UnityEngine;

public class HeroParty : MonoBehaviour
{
    [field: SerializeField] public List<Hero> Heroes { get; private set; } = new();
}
