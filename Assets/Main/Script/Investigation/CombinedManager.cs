using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class CombinedManager : MonoBehaviour
{
    public static CombinedManager Instance
    {
        get; 
        private set;
    }

    public TextAsset inkFile;

    Story story;

    TextArchitect architect;

    bool activeDialogue = false;

    Character activeCharacter;

    [SerializeField] private GameObject dialogue;
    [SerializeField] private GameObject L, T, M, Z;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        // new ink story
        story = new Story(inkFile.text);

        architect = new TextArchitect(DialogueSystem.instance.dialogueContainer.dialogueText);
        
        dialogue.SetActive(false);
    }

    private void Update()
    {
        if (!activeDialogue)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (architect.isBuilding)
            {
                if (!architect.hurryUp)
                    architect.hurryUp = true;
                else
                    architect.ForceComplete();
            }

            else
            {
                AdvanceStory();
            }
        }

        hideAndShow();
    }

    public void PlayKnot(string Name)
    {
        if (story == null)
        {
            Debug.Log("Not initiallized");
            return;
        }

        story.ResetState();
        story.ChoosePathString(Name);

        activeDialogue = true;
        dialogue.SetActive(true);

        DialogueSystem.instance.dialogueContainer.dialogueText.text = "";
        AdvanceStory();
    }

    void AdvanceStory()
    {
        if (story.canContinue)
        {
            string line = story.Continue();
            ApplyTags();
            architect.Build(line);
            return;
        }

        EndDialogue();
    }

    void EndDialogue()
    {
        activeDialogue = false;

        dialogue.SetActive(false);

        Debug.Log("END OF STORY");
    }

    void ApplyTags()
    {
        foreach (string tag in story.currentTags)
        {
            string[] split = tag.Split(' ');

            if (split.Length < 2)
                continue;

            string prefix = split[0].ToLower();
            string param = split[1];

            switch (prefix)
            {
                case "speaker":
                    SetSpeaker(param);
                    break;

                case "expression":
                    SetExpression(param);
                    break;
            }
        }
    }

    void SetSpeaker(string speakerName)
    {
        activeCharacter = CharacterManager.Instance.GetCharacter(speakerName);

        if (activeCharacter != null)
        {
            DialogueSystem.instance.dialogueContainer.nameText.text = activeCharacter.characterName;
        }
        else
        {
            Debug.LogWarning("No character found: " + speakerName);
        }
    }

    void SetExpression(string expression)
    {
        if (activeCharacter != null)
        {
            activeCharacter.SetExpression(expression);
        }
    }

    void hideAndShow()
    {
        if (dialogue.activeInHierarchy)
        {
            if (L != null)
            {
                L.SetActive(false);
            }

            if (T != null)
            {
                T.SetActive(false);
            }

            if (M != null)
            {
                M.SetActive(false);
            }

            if (Z != null)
            {
                Z.SetActive(false);
            }
        }

        else
        {
            if (L != null)
            {
                L.SetActive(true);
            }

            if (T != null)
            {
                T.SetActive(true);
            }

            if (M != null)
            {
                M.SetActive(true);
            }

            if (Z != null)
            {
                Z.SetActive(true);
            }
        }
    }
}