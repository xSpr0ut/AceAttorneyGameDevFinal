using UnityEngine;

public class EvidenceProperties : MonoBehaviour

{

    public bool selected;
    public int evidenceNo;
    public Sprite evidenceSprite;
    public string evidenceName;
    public string evidenceDesc;

    //UI stuff, how the selector looks
    [SerializeField] public GameObject unselectedBorder;
    [SerializeField] public GameObject selectedBorder;
    [SerializeField] public GameObject selectedTri;
    [SerializeField] public GameObject image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            selectedBorder.SetActive(true);
            selectedTri.SetActive(true);
            unselectedBorder.SetActive(false);
        }
        else
        {
            selectedBorder.SetActive(false);
            selectedTri.SetActive(false);
            unselectedBorder.SetActive(true);

        }
    }
}
