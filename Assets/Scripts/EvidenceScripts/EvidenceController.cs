using UnityEngine;

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
                //Debug.Log("poop");
            }
        }
    }
    void AddEvidence(string name, string desc, Sprite sprite)
    {
        GameObject newEvidence = new GameObject(name);
        newEvidence.GetComponent<EvidenceProperties>().evidenceName = name;
        newEvidence.GetComponent<EvidenceProperties>().evidenceDesc = desc;
        newEvidence.GetComponent<EvidenceProperties>().evidenceSprite = sprite;
        navi.GetComponent<EvidenceNavigator>().evidence.Add(newEvidence);
    }
}
