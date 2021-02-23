using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Monster", menuName = "Create New Monster")]
public class MonsterTemplate : ScriptableObject
{
    public enum CharacterType{ vampire, werewolf, killer, alien, zombie, clown, other}
    [Header("The character's REAL type:")]
    public CharacterType monstersType = CharacterType.other;
    public Texture profileImage;
    public string name;
    public string username;
    [TextArea(15,20)]
    public string profileDescription;
    public int relationshipScore = 10;
    [UnityEngine.Range(0, 10)]
    public int attraction = 5;
    [UnityEngine.Range(0, 10)]
    public int intelligence = 5;
    [UnityEngine.Range(0, 10)]
    public int humor = 5;
    public string[] likes = new string[] {"Pizza [Example]", "Sushi [Example]", "Long walks [Example]"};
    public string[] dislikes = new string[] {"Jogging [Example]", "Fish [Example]", "Stakes [Example]"};
}

