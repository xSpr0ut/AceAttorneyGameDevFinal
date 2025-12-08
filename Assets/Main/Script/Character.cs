using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
    public string characterName;
    public Sprite defaultPortrait;
    public Dictionary<string, Sprite> expressions;

    //Fade In & Fade Out
    public CanvasGroup canvasGroup;

    public void Awake()
    {
        if(canvasGroup == null)
           canvasGroup = GetComponent<CanvasGroup>();
    }

    //Play Animations, Switch Expression, etc
    public void SetExpression(string id)
    {
        if (expressions.ContainsKey(id))
        {
            //example: update portrait ui
            //DialogueManager.instance.dialogueContainer.portrait.sprite = expressions[id];
        }
    }

    //Fade to targetAlpha over duration of time
    public IEnumerator FadeTo(float targetAlpha, float duration)
    {
        float start = canvasGroup.alpha;
        float time = 0f;

        while (time < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(start, targetAlpha, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = targetAlpha;
    }
}
