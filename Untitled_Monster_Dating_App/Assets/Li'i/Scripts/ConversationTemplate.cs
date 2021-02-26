using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Conversation", menuName = "Create New Conversation")]
public class ConversationTemplate : ScriptableObject
{
    [Header("Template of Monster that is speaking:")]
    public MonsterTemplate monsterTemplate;
    [TextArea(15,20)]
    public string Dialog;
    public string[] reponses = new string[] {"Yes. [Example]", "No. [Example]", "What does that mean? [Example]"};
    public int[] valueOfReponses = new int[] {1, -1, 0};
    [Header("The Dialog each Response leads to:")]
    public ConversationTemplate[] branchConversations = new ConversationTemplate[3];
}
