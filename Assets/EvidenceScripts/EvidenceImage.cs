using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class EvidenceImage : MonoBehaviour
{
    [SerializeField] public EvidenceNavigator navi;
    [SerializeField] public Image imageDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int selected = navi.selectedEvidence;
        Sprite evidenceImage = navi.evidence[selected].evidenceSprite;

        imageDisplay = GetComponent<Image>();
        imageDisplay.sprite = evidenceImage;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void UpdateImage()
    {
        if (navi.category == EvidenceCategory.Evidence)
        {
            int selected = navi.selectedEvidence;
            Sprite evidenceImage = navi.evidence[selected].evidenceSprite;

            imageDisplay = GetComponent<Image>();
            imageDisplay.sprite = evidenceImage;
        }
        else if (navi.category == EvidenceCategory.People)
        {
            int selected = navi.selectedEvidence;
            Sprite evidenceImage = navi.people[selected].evidenceSprite;

            imageDisplay = GetComponent<Image>();
            imageDisplay.sprite = evidenceImage;
        }
    }
}
