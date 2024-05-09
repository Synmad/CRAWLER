using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TurnIndicatorController : MonoBehaviour
{
    UIDocument _document;

    Label _label;

    private void OnEnable()
    {
        TurnManager.onTurnChanged += UpdateText;
    }

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _label = _document.rootVisualElement.Q<Label>("TurnIndicator");
    }


    void UpdateText()
    {
        _label.text = "Es el turno de " + TurnManager.Instance.CurrentCombatant.name;
    }

    private void OnDisable()
    {
        TurnManager.onTurnChanged -= UpdateText;
    }
}
