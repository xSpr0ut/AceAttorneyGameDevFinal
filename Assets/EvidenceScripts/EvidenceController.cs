using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

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
                navi.selectedEvidence = 0;
                //Debug.Log("poop");
            }
        }

    }

    public void SetSlotsActive(List<GameObject> slots, List<GameObject> hideSlots)
    {
        if (EvidenceTab.activeInHierarchy)
        {
            if (navi.category == EvidenceCategory.Evidence)
            {
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
    }
}

