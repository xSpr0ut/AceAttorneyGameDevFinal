using UnityEngine;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
    public string characterName;
    public Sprite defaultPortrait;
    public Dictionary<string, Sprite> expressions;

    //Play Animations, Switch Expression, etc
    public void SetExpression(string id)
    {
        if (expressions.ContainsKey(id))
        {
            //example: update portrait ui
            //DialogueManager.instance.dialogueContainer.portrait.sprite = expressions[id];
        }
    }
}
