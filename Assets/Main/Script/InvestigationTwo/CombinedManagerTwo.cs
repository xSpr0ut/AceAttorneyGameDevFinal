using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class CombinedManagerTwo : MonoBehaviour
{
    public static CombinedManagerTwo Instance
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
    [SerializeField] private GameObject M, R, S, L;
    [SerializeField] private GameObject SpriteM, SpriteR, SpriteS, SpriteL;
    public bool playingM = false;
    public bool playingR = false;
    public bool playingS = false;
    public bool playingL = false;

    public AudioSource typeSource;
    public AudioClip type;

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
        SpriteM.SetActive(false);
        SpriteR.SetActive(false);
        SpriteS.SetActive(false);
        SpriteL.SetActive(false);
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
                {
                    architect.hurryUp = true;

                    if (!typeSource.isPlaying)
                    {
                        typeSource.PlayOneShot(type);
                    }
                }

                else
                {
                    architect.ForceComplete();

                    if (typeSource.isPlaying)
                    {
                        typeSource.Stop();
                    }
                }
            }

            else
            {
                AdvanceStory();

                if (!typeSource.isPlaying)
                {
                    typeSource.PlayOneShot(type);
                }
            }
        }

        if (architect.isBuilding)
        {
            if (!architect.hurryUp)
            {
                if (!typeSource.isPlaying)
                {
                    typeSource.PlayOneShot(type);
                }
            }
            else
            {
                if (typeSource.isPlaying)
                {
                    typeSource.Stop();
                }
            }
        }

        else
        {
            if (typeSource.isPlaying)
            {
                typeSource.Stop();
            }
        }

        hideAndShow();
    }

    public void PlayKnot(string Name)
    {
        if (!typeSource.isPlaying)
        {
            typeSource.PlayOneShot(type);
        }

        if (story == null)
        {
            Debug.Log("Not initiallized");
            return;
        }

        if (Name == "Mirror")
        {
            SpriteM.SetActive(true);
        }

        if (Name == "Rack")
        {
            SpriteR.SetActive(true);
        }

        if (Name == "Scanner")
        {
            SpriteS.SetActive(true);
        }

        if (Name == "Letter")
        {
            SpriteL.SetActive(true);
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
        if (typeSource.isPlaying)
        {
            typeSource.Stop();
        }

        activeDialogue = false;

        dialogue.SetActive(false);
        SpriteM.SetActive(false);
        SpriteR.SetActive(false);
        SpriteS.SetActive(false);
        SpriteL.SetActive(false);

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
            if (M != null)
            {
                M.SetActive(false);
            }

            if (R != null)
            {
                R.SetActive(false);
            }

            if (S != null)
            {
                S.SetActive(false);
            }

            if (L != null)
            {
                L.SetActive(false);
            }
        }

        else
        {
            if (M != null)
            {
                M.SetActive(true);
            }

            if (R != null)
            {
                R.SetActive(true);
            }

            if (S != null)
            {
                S.SetActive(true);
            }

            if (L != null)
            {
                L.SetActive(true);
            }
        }
    }
}