using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Scriptable Objects/Skill")]
public class Skill : ScriptableObject
{
    [SerializeField] string _name;
    [field:SerializeField] public string Output {get; private set;}
}
