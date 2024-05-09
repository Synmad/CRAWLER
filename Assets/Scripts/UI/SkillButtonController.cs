using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillButtonController : MonoBehaviour
{
    UIDocument _document;

    VisualElement _skillButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _skillButton = _document.rootVisualElement.Q("SkillButtonA");

        _skillButton.RegisterCallback<ClickEvent>(OnClicked);
    }

    private void OnClicked(ClickEvent e)
    {
        if (TurnManager.Instance.CurrentCombatant is HeroController)
        {
            Debug.Log(TurnManager.Instance.CurrentCombatant.Skills[0].Output);
        }
        else return;
    }
}
