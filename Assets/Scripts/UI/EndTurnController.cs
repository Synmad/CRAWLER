using UnityEngine;
using UnityEngine.UIElements;

public class EndTurnController : MonoBehaviour
{
    UIDocument _document;

    VisualElement _button;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q("EndTurnButton");

        _button.RegisterCallback<ClickEvent>(OnClicked);
    }

    void OnClicked(ClickEvent e)
    {
        TurnManager.Instance.NextTurn();
    }
}
