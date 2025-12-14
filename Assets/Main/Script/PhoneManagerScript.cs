using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Ink.Runtime;

public class PhoneManagerScript : MonoBehaviour
{

    [SerializeField] private GameObject phonePanel;
    [SerializeField] private GameObject dialogueSystem;
    [SerializeField] private GameObject Characters;
    [SerializeField] private DialogueManager dialogueManager;

    // variables for which contacts are available
    /*
    public bool olafKannaContact = false;
    public bool paparazziContact = false;
    public bool fanContact = false;
    */
    private String currentPhoneCall = "";

    // INK STUFF
    public TextAsset inkFile;
    Story story;
    TextArchitect architect;
    bool activeDialogue = false;
    Character activeCharacter;
    public Transform choicePanel;
    public GameObject choiceButtonPrefab;
    public GameObject nextSceneButton;

    // checking if they've been called:
    public bool calledOlaf = false;
    public bool calledPaparazzi = false;
    public bool calledDr = false;
    public bool calledEileen = false;
    public bool calledFan = false;


    // ensures when the scene starts, the phone is off
    void Start()
    {
        phonePanel.SetActive(false);
        nextSceneButton.SetActive(false);

        // Connect Architect to your DialogueSystem text
        architect = new TextArchitect(DialogueSystem.instance.dialogueContainer.dialogueText);

        dialogueSystem.SetActive(false);

         // Create Ink story
        story = new Story(inkFile.text);

        //Automatically go to first line
    }

    public void OpenPhone()
    {
        if(activeDialogue == false){
        phonePanel.SetActive(true);
        nextSceneButton.SetActive(false);
        }

    }

    public void ClosePhone()
    {
        
        phonePanel.SetActive(false);

    }

    public void nextScene()
    {
        if(SceneManager.GetActiveScene().name == "PhoneScene1"){
        SceneManager.LoadScene("NadineScene2");
        } else if(SceneManager.GetActiveScene().name == "PhoneScene2"){
        SceneManager.LoadScene("FanScene2");
        }

    }

    // if phone is clicked on, phone screen will open
    public void OnMouseDown()
    {
        OpenPhone();
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
        dialogueSystem.SetActive(true);

        DialogueSystem.instance.dialogueContainer.dialogueText.text = "";
        AdvanceStory();
    }

    // TO PLAY DIRECTLY FROM THE RESPECTIVE CHARACTER'S
    // INK KNOT

    public void OnOlafButtonDown()
    {
        
        if(SceneManager.GetActiveScene().name == "PhoneScene2"){
            PlayKnot("NoAnswer");
            ClosePhone();
        } else {

    //   dialogueSystem.SetActive(true);
        Characters.SetActive(false);
        PlayKnot("OlafPhoneCall");
        calledOlaf = true;
     //   dialogueManager.ShowFirstLine();
        ClosePhone();
        
        }

    }

    public void OnPaparazziButtonDown()
    {

         if(SceneManager.GetActiveScene().name == "PhoneScene2"){
            PlayKnot("NoAnswer");
            ClosePhone();
        } else {

        PlayKnot("DavidYellowPhoneCall");
        calledPaparazzi = true;
        ClosePhone();

        }
        
    }

    public void OnFanButtonDown()
    {

        PlayKnot("FanPhoneCall");
        calledFan = true;
        ClosePhone();

        
    }

    public void OnDoctorButtonDown()
    {

        if(SceneManager.GetActiveScene().name == "PhoneScene2"){
        PlayKnot("NoAnswer");
        ClosePhone();
        } else {
        PlayKnot("DrLiuPhoneCall");
        calledDr = true;
        ClosePhone();
        }
        
    }

    public void OnMakeupArtistButtonDown()
    {
        PlayKnot("EileenPhoneCall");
        calledEileen = true;
        ClosePhone();
        
    }

    public void showButton()
    {
         if(SceneManager.GetActiveScene().name == "PhoneScene1"){
            if (calledOlaf && calledPaparazzi && calledDr)
            {
                nextSceneButton.SetActive(true);
            }
        } else if(SceneManager.GetActiveScene().name == "PhoneScene2"){
            if (calledFan && calledEileen)
            {
                nextSceneButton.SetActive(true);
            }
        }
    }

    // DIALOGUE SCRIPT

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

    }
        void AdvanceStory()
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
            ShowChoices();
            return;
        }

       // Debug.Log("END OF STORY");
       showButton();
       EndDialogue();
    }

    void EndDialogue()
    {
        activeDialogue = false;
        dialogueSystem.SetActive(false);

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
            btn.Init(c.text, i, OnChoiceSelected);
        }
    }

    void OnChoiceSelected(int choiceIndex)
    {
        choicePanel.gameObject.SetActive(false);

        story.ChooseChoiceIndex(choiceIndex);

        AdvanceStory();
    }


}
