using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.InputSystem.XR;
using TMPro;

// this should always exist in game. it controls when the evidence tabs pops up and can be accessed when you wanna add evidence after each discovery.
public class EvidenceController : MonoBehaviour
{
    [SerializeField] public EvidenceNavigator navi;
    [SerializeField] public GameObject EvidenceTab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EvidenceTab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (EvidenceTab.activeInHierarchy)
            {
                EvidenceTab.SetActive(false);
            }
            else
            {
                EvidenceTab.SetActive(true);

                // RESET 
                navi.evidenceSlot[navi.selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                navi.peopleSlot[navi.selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
                navi.selectedEvidence = 0;
   

                TextMeshProUGUI categoryTextDisplay = navi.categoryText.GetComponent<TextMeshProUGUI>();
                navi.evidenceSlot[0].GetComponent<EvidenceProperties>().selected = true;
                navi.category = EvidenceCategory.Evidence;
                categoryTextDisplay.text = "Evidence";
                SetSlotsActive(navi.evidenceSlot, navi.peopleSlot);

                navi.image.GetComponent<EvidenceImage>().UpdateImage();
                navi.text.GetComponent<EvidenceText>().UpdateText();
                //Debug.Log("diarrhea");
            }
        }

    }

    public void SetSlotsActive(List<GameObject> slots, List<GameObject> hideSlots)
    {
        if (!EvidenceTab.activeInHierarchy) { return; }

        for (int i = 0; i < slots.Count; i++)
        {
            slots[i].SetActive(true);
        }
        for (int i = 0; i < hideSlots.Count; i++)
        {
            hideSlots[i].SetActive(false);
        }
         
        
    }
}

