using UnityEngine;
using System.Collections.Generic;

public enum EvidenceCategory
{
    Evidence,
    People
}

public class EvidenceNavigator : MonoBehaviour
{

    public EvidenceCategory category;

    // data structures for evidence management
    [SerializeField] public List<GameObject> evidenceSlot; // 10 existing evidence slots
    public List<EvidenceSO> evidence; // 1-10 existing acquired evidence
    public int selectedEvidence;
    //private EvidenceProperties prop; ignore this for now

    // our first piece of evidence
    [SerializeField] public GameObject image;
    [SerializeField] public GameObject text;
    [SerializeField] public EvidenceSO attorneysBadge;

    // TESTING, DELETE LATER
    [SerializeField] public EvidenceSO hairpin;
    [SerializeField] public EvidenceSO autopsy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        category = EvidenceCategory.Evidence;

        addEvidence(attorneysBadge);

        // TESTING, DELETE LATER
        addEvidence(hairpin);
        addEvidence(autopsy);

        selectedEvidence = 0;
        evidenceSlot[0].GetComponent<EvidenceProperties>().selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (category == EvidenceCategory.Evidence)
            {
                category = EvidenceCategory.People;
            }
            else
            {
                category = EvidenceCategory.Evidence;
            }
        }

        if (category == EvidenceCategory.Evidence) { 
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
    }

    public void addEvidence(EvidenceSO evidenceAssignment)
    {

        evidence.Add(evidenceAssignment);

        int evidenceNum = evidence.Count - 1;
        evidenceAssignment.evidenceNo = evidenceNum + 1;

        GameObject accessSlot = evidenceSlot[evidenceNum];
        accessSlot.GetComponent<EvidenceProperties>().AssignEvidence(evidenceAssignment);
    }
}
