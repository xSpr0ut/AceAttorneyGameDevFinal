using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.InputSystem.XR;
using TMPro;

// this should always exist in game. it controls when the evidence tabs pops up and can be accessed when you wanna add evidence after each discovery.
public class EvidenceController : MonoBehaviour
{
    public static EvidenceController Instance { get; private set; }

    [SerializeField] public EvidenceNavigator navi;
    [SerializeField] public GameObject EvidenceTab;
    [SerializeField] public GameObject OpenEvidenceImage;
    [SerializeField] public GameObject Present;

    public bool isCrossExaminating;
    public string presentName;

    //Awake
    void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EvidenceTab.SetActive(false);
        Present.SetActive(false);

        isCrossExaminating = false;
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

                SetTabActive();

                //Debug.Log("diarrhea");
            }
        }

        if (EvidenceTab.activeInHierarchy && isCrossExaminating && Input.GetKeyDown(KeyCode.E))
        {

            presentName = GetEvidence().evidenceName;
            Debug.Log(presentName);
            EvidenceTab.SetActive(false);
            Present.SetActive(false);

            //DialogueManager
            DialogueManager.Instance.OnEvidencePresented(presentName);
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

    public void SetTabActive()
    {
        EvidenceTab.SetActive(true);

        // RESET 
        navi.evidenceSlot[navi.selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
        navi.peopleSlot[navi.selectedEvidence].GetComponent<EvidenceProperties>().selected = false;
        navi.selectedEvidence = 0;
        navi.openImage = false;
        OpenEvidenceImage.SetActive(false);


        TextMeshProUGUI categoryTextDisplay = navi.categoryText.GetComponent<TextMeshProUGUI>();
        navi.evidenceSlot[0].GetComponent<EvidenceProperties>().selected = true;
        navi.category = EvidenceCategory.Evidence;
        categoryTextDisplay.text = "Evidence";
        SetSlotsActive(navi.evidenceSlot, navi.peopleSlot);

        navi.image.GetComponent<EvidenceImage>().UpdateImage();
        navi.text.GetComponent<EvidenceText>().UpdateText();

        if (isCrossExaminating)
        {
            Present.SetActive(true);
        }
    }

    // to obtain name, do [controller].GetEvidence().evidenceName
    public EvidenceSO GetEvidence()
    {
        if (navi.category == EvidenceCategory.Evidence)
        {
            return navi.evidence[navi.selectedEvidence];
        }
        else
        {
            return navi.people[navi.selectedEvidence];
        }
        
    }
}
