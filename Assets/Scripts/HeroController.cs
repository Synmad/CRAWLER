using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : CombatUnit
{
    [SerializeField] Hero _heroSO;

    private void Awake()
    {
        Skills.AddRange(_heroSO.Skills);
    }
}
