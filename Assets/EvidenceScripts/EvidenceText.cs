using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class EvidenceText : MonoBehaviour
{
    [SerializeField] public EvidenceNavigator navi;
    [SerializeField] public GameObject title;
    [SerializeField] public GameObject description;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int selected = navi.selectedEvidence;
        string evidenceTitleText = navi.evidence[selected].evidenceName;
        TextMeshProUGUI textDisplayTitle = title.GetComponent<TextMeshProUGUI>();
        textDisplayTitle.text = evidenceTitleText;

        string evidenceDescText = navi.evidence[selected].evidenceDesc;
        TextMeshProUGUI textDisplayDesc = description.GetComponent<TextMeshProUGUI>();
        textDisplayDesc.text = evidenceDescText;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText()
    {
        int selected = navi.selectedEvidence;
        string evidenceTitleText = navi.evidence[selected].evidenceName;
        TextMeshProUGUI textDisplayTitle = title.GetComponent<TextMeshProUGUI>();
        textDisplayTitle.text = evidenceTitleText;

        string evidenceDescText = navi.evidence[selected].evidenceDesc;
        TextMeshProUGUI textDisplayDesc = description.GetComponent<TextMeshProUGUI>();
        textDisplayDesc.text = evidenceDescText;
    }
}
