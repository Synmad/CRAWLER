using System.Collections.Generic;
using UnityEngine;

public class HeroParty : MonoBehaviour
{
    [field: SerializeField] public List<HeroController> Heroes { get; private set; } = new();
}
