using System.Collections.Generic;
using UnityEngine;

public class CombatantsManager : MonoBehaviour
{
    [SerializeField] EnemyParty _enemyParty;
    [SerializeField] HeroParty _heroParty;

    public List<CombatUnit> Combatants { get; private set; } = new();

    public static CombatantsManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        SortCombatants();
    }

    void SortCombatants()
    {
        for(int i = 0; i < _enemyParty.Enemies.Count; i++)
        {
            Combatants.Add(_enemyParty.Enemies[i]);
        }
        for (int i = 0; i < _heroParty.Heroes.Count; i++)
        {
            Combatants.Add(_heroParty.Heroes[i]);
        }

        Combatants.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
    }
}
