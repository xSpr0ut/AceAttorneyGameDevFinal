using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using System.Collections.Generic;

public class VNController : MonoBehaviour
{
    [Header("UI Groups")]
    public GameObject dialogueGroup;   // 4 - Dialogue
    public GameObject controlsGroup;   // 6 - Controls
    public GameObject choicesGroup;    // 7 - Choices

    [Header("Choices")]
    public Transform choicesContainer; // Parent Button Object
    public GameObject choiceButtonPrefab;

    [Header("Ink")]
    public TextAsset inkFile;
    private Story story;

    void Start()
    {
        story = new Story(inkFile.text);

        // Make sure choices UI is hidden on start
        choicesGroup.SetActive(false);
    }

    // -------------------------
    // INKY Functions
    // -------------------------
    void ContinueStory()
    {
        // Case 1 — Ink has more dialogue
        if (story.canContinue)
        {
            HideChoicesUI();
            string line = story.Continue();

            // Feed into your typewriter system here
            // For now, just log it:
            Debug.Log("INK LINE: " + line);

            return;
        }

        // Case 2 — Ink has choices
        if (story.currentChoices.Count > 0)
        {
            ShowChoicesUI();
            DisplayChoices();
            return;
        }

        // Case 3 — No more story
        Debug.Log("END OF STORY");
    }

    // -------------------------
    // SHOW/HIDE UI GROUPS
    // -------------------------

    public void ShowChoicesUI()
    {
        dialogueGroup.SetActive(false);
        controlsGroup.SetActive(false);
        choicesGroup.SetActive(true);
    }

    public void HideChoicesUI()
    {
        dialogueGroup.SetActive(true);
        controlsGroup.SetActive(true);
        choicesGroup.SetActive(false);
    }

    void DisplayChoices()
    {
        // Clear old buttons
        foreach (Transform child in choicesContainer)
            Destroy(child.gameObject);

        // Spawn new buttons
        for (int i = 0; i < story.currentChoices.Count; i++)
        {
            Choice choice = story.currentChoices[i];

            // Create the button
            GameObject buttonObj = Instantiate(choiceButtonPrefab, choicesContainer);

            // Set the text on the button
            TMP_Text text = buttonObj.GetComponentInChildren<TMP_Text>();
            text.text = choice.text;

            // Capture loop variable
            int choiceIndex = i;

            // Add click event
            buttonObj.GetComponent<Button>().onClick.AddListener(() =>
            {
                OnChoiceSelected(choiceIndex);
            });
        }
    }

    void OnChoiceSelected(int index)
    {
        story.ChooseChoiceIndex(index);
        HideChoicesUI();    // hide buttons, show dialogue UI
        ContinueStory();    // continue Ink story
    }
}
