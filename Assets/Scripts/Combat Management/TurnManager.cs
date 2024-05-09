using System;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance { get; private set; }

    private void Awake() => Instance = this;

    public CombatUnit CurrentCombatant {get; private set;}
    int _currentTurn;

    public static Action onTurnChanged;

    private void Start()
    {
        CurrentCombatant = CombatantsManager.Instance.Combatants[_currentTurn];
        onTurnChanged?.Invoke();
        Debug.Log(CurrentCombatant.name);
    }

    public void NextTurn()
    {
        onTurnChanged?.Invoke();
        _currentTurn++;
        if(_currentTurn >= CombatantsManager.Instance.Combatants.Count)
        {
            _currentTurn = 0;
        }
        CurrentCombatant = CombatantsManager.Instance.Combatants[_currentTurn];
        Debug.Log(CurrentCombatant.name);
    }

}
