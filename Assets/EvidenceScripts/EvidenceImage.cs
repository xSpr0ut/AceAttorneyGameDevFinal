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
        imageDisplay = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        int selected = navi.selectedEvidence;

        Sprite evidenceImage = navi.evidence[selected].evidenceSprite;
        imageDisplay.sprite = evidenceImage;
    }
}
