using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public enum EvidenceCategory
{
    Evidence,
    People
}

public class EvidenceNavigator : MonoBehaviour
{
    /* i apologize for how spaghetti everything is
     * 3 years of cs rly paid off
     * but feel free to ask about anything
     */

    public EvidenceCategory category;

    // data structures for evidence management
    [SerializeField] public EvidenceController controller;
    [SerializeField] public GameObject categoryText;
    [SerializeField] public List<GameObject> evidenceSlot; // 10 existing evidence slots
    [SerializeField] public List<GameObject> peopleSlot;
    public List<EvidenceSO> evidence; // 1-10 existing acquired evidence
    public List<EvidenceSO> people;
    public int selectedEvidence;

    // if there is an image open, you are not allowed to navigate
    public bool openImage;

    // our first piece of evidence
    [SerializeField] public GameObject image;
    [SerializeField] public GameObject text;
    [SerializeField] public EvidenceSO attorneysBadge;
    [SerializeField] public EvidenceSO assistant;
    [SerializeField] public EvidenceSO forensicsScientist;

    // TESTING, DELETE LATER
    [SerializeField] public EvidenceSO hairpin;
    [SerializeField] public EvidenceSO autopsy;
    [SerializeField] public EvidenceSO paparazziPhoto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        category = EvidenceCategory.Evidence;
        controller.SetSlotsActive(evidenceSlot, peopleSlot);
        openImage = false;

        // GAME START DEFAULTS
        addEvidence(attorneysBadge);
        addPeople(assistant);
        addPeople(forensicsScientist);

        // TESTING, DELETE THESE LATER
        addEvidence(hairpin);
        addEvidence(autopsy);
        addEvidence(paparazziPhoto);

        selectedEvidence = 0;
        evidenceSlot[0].GetComponent<EvidenceProperties>().selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!openImage)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                TextMeshProUGUI categoryTextDisplay = categoryText.GetComponent<TextMeshProUGUI>();
                evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                peopleSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                selectedEvidence = 0;

                if (category == EvidenceCategory.Evidence)
                {
                    peopleSlot[0].GetComponent<EvidenceProperties>().selected = true;
                    category = EvidenceCategory.People;
                    categoryTextDisplay.text = "People";
                    controller.SetSlotsActive(peopleSlot, evidenceSlot);
                }
                else
                {
                    evidenceSlot[0].GetComponent<EvidenceProperties>().selected = true;
                    category = EvidenceCategory.Evidence;
                    categoryTextDisplay.text = "Evidence";
                    controller.SetSlotsActive(evidenceSlot, peopleSlot);
                }

                image.GetComponent<EvidenceImage>().UpdateImage();
                text.GetComponent<EvidenceText>().UpdateText();
            }

            if (category == EvidenceCategory.Evidence)
            {
                if (selectedEvidence != 0 && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)))
                {
                    evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                    selectedEvidence--;
                    evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = true;
                    image.GetComponent<EvidenceImage>().UpdateImage();
                    text.GetComponent<EvidenceText>().UpdateText();

                }
                if (selectedEvidence != evidence.Count - 1 && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
                {
                    evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                    selectedEvidence++;
                    evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = true;
                    image.GetComponent<EvidenceImage>().UpdateImage();
                    text.GetComponent<EvidenceText>().UpdateText();

                }
            }
            else if (category == EvidenceCategory.People)
            {
                if (selectedEvidence != 0 && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)))
                {
                    peopleSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                    selectedEvidence--;
                    peopleSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = true;
                    image.GetComponent<EvidenceImage>().UpdateImage();
                    text.GetComponent<EvidenceText>().UpdateText();

                }
                if (selectedEvidence != people.Count - 1 && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
                {
                    peopleSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                    selectedEvidence++;
                    peopleSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = true;
                    image.GetComponent<EvidenceImage>().UpdateImage();
                    text.GetComponent<EvidenceText>().UpdateText();

                }
            }
        }
    }

    /* HOW ADDING EVIDENCE WORKS:
     * 1. Reference the Evidence Navigator and the EvidenceSO object you want to add.
     * 2. Use the addEvidence function: getComponent<EvidenceNavigator>.addEvidence(EvidenceSO);
     * 3. It should pop up in your inventory. Be careful not to allow evidence be acquired twice.
     * 4. You can access the EvidenceSO's data. Check EvidenceSO.cs for all its data types.
     * 
     * This applies the same for people, but obviosly it's using the addPeople() function.
     * Ask Shannon if you have any questions!!
     */
    public void addEvidence(EvidenceSO evidenceAssignment)
    {

        evidence.Add(evidenceAssignment);

        int evidenceNum = evidence.Count - 1;
        evidenceAssignment.evidenceNo = evidenceNum + 1;

        GameObject accessSlot = evidenceSlot[evidenceNum];
        accessSlot.GetComponent<EvidenceProperties>().AssignEvidence(evidenceAssignment, false);
    }

    public void addPeople(EvidenceSO peopleAssignment)
    {
        people.Add(peopleAssignment);

        int peopleNum = people.Count - 1;
        peopleAssignment.evidenceNo = peopleNum + 1;

        GameObject accessSlot = peopleSlot[peopleNum];
        accessSlot.GetComponent<EvidenceProperties>().AssignEvidence(peopleAssignment, true);
    }
}
