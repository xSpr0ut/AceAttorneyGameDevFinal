using UnityEngine;
using System.Collections.Generic;

public enum EvidenceCategory
{
    Evidence,
    People
}

public class EvidenceNavigator : MonoBehaviour
{
    // data structures for evidence management
    [SerializeField] public List<GameObject> evidenceSlot; // 10 existing evidence slots
    public List<EvidenceSO> evidence; // 1-10 existing acquired evidence
    public int selectedEvidence;
    //private EvidenceProperties prop; ignore this for now

    // our first piece of evidence
    [SerializeField] public EvidenceSO attorneysBadge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        evidence.Add(attorneysBadge);

        selectedEvidence = 0;
        evidenceSlot[0].GetComponent<EvidenceProperties>().selected = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (selectedEvidence != 0 && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
            selectedEvidence--;
            evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = true;

        }
        if (selectedEvidence != evidence.Count - 1 && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
            selectedEvidence++;
            evidenceSlot[selectedEvidence].GetComponent<EvidenceProperties>().selected = true;

        }
    }
}
