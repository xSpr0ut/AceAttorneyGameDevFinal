using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public string characterName;

    //Default Portrait for Character
    public Image portrait;

    //Default Expression
    public Sprite defaultPortrait;

    //Sprite Renderer
    public SpriteRenderer spriteRenderer;

    //Dictionary of Expressions + List to Enter them through Inspector
    public List<ExpressionEntry> expressionList = new List<ExpressionEntry>();
    private Dictionary<string, Sprite> expressions = new Dictionary<string, Sprite>();

    //Fade In & Fade Out
    public CanvasGroup canvasGroup;

    public void Awake()
    {
        //Create Canvas Group
        if(canvasGroup == null)
           canvasGroup = GetComponent<CanvasGroup>();

        //Build dictionary for quick lookup of expressions
        foreach (var entry in expressionList)
            expressions[entry.id.ToLower()] = entry.sprite;

        //Set Default Portrait
        if(portrait != null)
            portrait.sprite = defaultPortrait;
    }

    //Play Animations, Switch Expression, etc
    public void SetExpression(string expressionID)
    {
        expressionID = expressionID.ToLower();

        //if expresison is found
        if(expressions.ContainsKey(expressionID))
        {
            portrait.sprite = expressions[expressionID];
            Debug.Log($"{characterName} expression set to {expressionID}");
        }
        else
        {
            Debug.LogWarning($"Expression '{expressionID}' not found for {characterName}");
        }
    }

    [System.Serializable]
    public class ExpressionEntry
    {
        public string id;
        public Sprite sprite;
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

    //Helper function to set alpha of a character (Opacity)
    public void SetAlpha(float a)
    {
        if(spriteRenderer != null)
        {
            Color col = spriteRenderer.color;
            col.a = a;
            spriteRenderer.color = col;
        }
    }
}
