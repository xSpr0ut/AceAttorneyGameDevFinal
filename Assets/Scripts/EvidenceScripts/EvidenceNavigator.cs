using UnityEngine;
using System.Collections.Generic;

public enum EvidenceCategory
{
    Evidence,
    People
}

public class EvidenceNavigator : MonoBehaviour
{
    [SerializeField] public List<GameObject> evidence;
    private int selectedEvidence;
    private EvidenceProperties prop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        selectedEvidence = 0;
        evidence[0].GetComponent<EvidenceProperties>().selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedEvidence != evidence.Count - 1 && Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            evidence[selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
            selectedEvidence = 1;
            
        }
    }
}
