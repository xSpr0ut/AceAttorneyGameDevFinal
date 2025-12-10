using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    [SerializeField] private GameObject T, M, Z;
    [SerializeField] private GameObject SpriteT, SpriteM, SpriteZ;
    public bool playingT = false;
    public bool playingM = false;
    public bool playingZ = false;

    public AudioSource typeSource;
    public AudioClip type;
    
    // count for number of items used
    // so we can #activate the button
    public int itemCounter = 3;
    public GameObject buttonToShow;

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
        SpriteT.SetActive(false); 
        SpriteM.SetActive(false); 
        SpriteZ.SetActive(false);

        buttonToShow.SetActive(false);   
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

        nextButtonShow();
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

        if (Name == "Table")
        {
            SpriteT.SetActive(true);
        }

        if (Name == "Medkit")
        {
            SpriteM.SetActive(true);
        }

        if (Name == "Magazine")
        {
            SpriteZ.SetActive(true);
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
        SpriteT.SetActive(false);
        SpriteM.SetActive(false);
        SpriteZ.SetActive(false);

        itemCounter--;

        Debug.Log("END OF STORY");
    }

    public void nextButtonShow()
    {
        
        if(itemCounter <= 0)
        {
            buttonToShow.SetActive(true); 
            Debug.Log("Hello");  
        }

    }

    public void onButtonClick()
    {
        
        Debug.Log("IS CLICKED IS CLICKED");
        SceneManager.LoadScene("CoWorkerScene2");

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