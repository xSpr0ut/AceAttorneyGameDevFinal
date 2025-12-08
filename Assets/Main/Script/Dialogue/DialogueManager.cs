using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextAsset inkFile;
    public Transform choicePanel;
    public GameObject choiceButtonPrefab;

    //Cross Examination
    public Transform crossExaminationChoicePanel;
    public GameObject forwardPrefab;
    public GameObject backwardPrefab;

    public string currentStatementKnot = "";

    Story story;
    TextArchitect architect;

    //Dialogue Modes
    public enum DialogueMode 
    {
        Normal,
        CrossExamination
    }

    public DialogueMode currentMode = DialogueMode.Normal; //normal by default
    
    void Start()
    {
        // Create Ink story
        story = new Story(inkFile.text);

        // Connect Architect to your DialogueSystem text
        architect = new TextArchitect(DialogueSystem.instance.dialogueContainer.dialogueText);

        SceneManagerScript sm = SceneManagerScript.Instance;

        //Automatically go to first line
        ShowFirstLine();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If text is still typing
            if (architect.isBuilding)
            {
                if (!architect.hurryUp)
                    architect.hurryUp = true;
                else
                    architect.ForceComplete();
                return;
            }

            AdvanceStory();
        }
    }

    public void AdvanceStory()
    {
        // If Ink has more text
        if (story.canContinue)
        {
            string line = story.Continue();
            
            ApplyTags();

            architect.Build(line);
            return;
        }

        // If no more text but there are choices
        if (story.currentChoices.Count > 0)
        {
            //ShowChoices();

            if(currentMode == DialogueMode.CrossExamination)
                ShowCrossExaminationChoices();
            else if(currentMode == DialogueMode.Normal)
                ShowChoices();
            return;
        }

        Debug.Log("END OF STORY");
        SceneManagerScript sm = SceneManagerScript.Instance;
        sm.SwitchSceneTime(SceneManager.GetActiveScene().name);
    }

    void ShowFirstLine()
    {
        if(story.canContinue)
        {
            string line = story.Continue();
            ApplyTags();

            architect.Build(line);
        }
    }

    // Allows user to use tags for characters, expressions, etc on Inky
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
                
                case "goto":
                    story.ChoosePathString("Lover_Lines");
                    break;

                case "title":
                    ShowTitle(param);
                    break;
                
                //Track Current Line
                case "statement":
                    currentStatementKnot = param;
                    break;
                
                case "mode":
                    SetDialogueMode(param);
                    break;

                //Add more tags here
            }
        }
    }

    Character activeCharacter;

    void SetSpeaker(string speakerName)
    {
        activeCharacter = CharacterManager.Instance.GetCharacter(speakerName);

        if (activeCharacter != null)
        {
            DialogueSystem.instance.dialogueContainer.nameText.text = activeCharacter.characterName;

            //New Part: Activate the game object of the current speaker
            CharacterManager.Instance.SetActiveSpeaker(activeCharacter);
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

    void ShowTitle(string title)
    {
        //TitleCardUI.Instance.Show(title);
    }

    // -- Cross Examination Input -- //
    void SetDialogueMode(string modeName)
    {
        if (modeName == "Normal")
        {
            currentMode = DialogueMode.Normal;
        }
        else if (modeName == "CrossExamination")
        {
            currentMode = DialogueMode.CrossExamination;
        }

        Debug.Log("Mode switched to: " + currentMode);
    }

    // -- Cross Examination Buttons -- //
    void ShowCrossExaminationChoices()
    {
        crossExaminationChoicePanel.gameObject.SetActive(true);

        // Clear out old buttons
        foreach (Transform child in crossExaminationChoicePanel)
            Destroy(child.gameObject);

        // One button per choice
        for (int i = 0; i < story.currentChoices.Count; i++)
        {
            Choice c = story.currentChoices[i];

            // Decide WHICH prefab to use for this choice
            GameObject prefabToUse = null;

            if (c.text.Contains("Next"))
            {
                // This choice is the "go forward" option
                prefabToUse = forwardPrefab;
            }
            else if (c.text.Contains("Previous"))
            {
                // This choice is the "go back" option
                prefabToUse = backwardPrefab;
            }
            else
            {
                // Optional: fallback if you ever have some other text choice here
                prefabToUse = choiceButtonPrefab;
            }

            // Instantiate the correct button prefab
            GameObject buttonObj = Instantiate(prefabToUse, crossExaminationChoicePanel);

            // Your custom script on the prefab
            ChoiceButton btn = buttonObj.GetComponent<ChoiceButton>();

            // Hook it up to Ink like usual
            btn.Init(c.text, i, CrossExamChoiceSelected);
        }
    }

    void CrossExamChoiceSelected(int choiceIndex)
    {
        crossExaminationChoicePanel.gameObject.SetActive(false);

        story.ChooseChoiceIndex(choiceIndex);

        AdvanceStory();
    }


    // ---- Choices ---- //
    void ShowChoices()
    {
        choicePanel.gameObject.SetActive(true);

        // Clear old buttons
        foreach (Transform child in choicePanel)
            Destroy(child.gameObject);

        // Create a button for each choice
        for (int i = 0; i < story.currentChoices.Count; i++)
        {
            Choice c = story.currentChoices[i];
            GameObject buttonObj = Instantiate(choiceButtonPrefab, choicePanel);
            ChoiceButton btn = buttonObj.GetComponent<ChoiceButton>();
            btn.Init(c.text, i, OnChoiceSelected); //spawn button
        }
    }

    void OnChoiceSelected(int choiceIndex)
    {
        choicePanel.gameObject.SetActive(false);

        story.ChooseChoiceIndex(choiceIndex);

        AdvanceStory();
    }

}
