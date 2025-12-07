using UnityEngine;
using UnityEngine.UI;

public class EvidenceProperties : MonoBehaviour

{

    public bool selected;
    public EvidenceSO evidence;

    private Image slotColor;
    private Color colorHex;

    //UI stuff, how the selector looks
    [SerializeField] public GameObject unselectedBorder;
    [SerializeField] public GameObject selectedBorder;
    [SerializeField] public GameObject selectedTri;
    [SerializeField] public GameObject image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slotColor = GetComponent<Image>();
        Sprite evidenceimg = evidence.evidenceSprite;
        Image imageDisplay = image.GetComponent<Image>();
        imageDisplay.sprite = evidenceimg;

    }

    // Update is called once per frame
    void Update()
    {
        Sprite evidenceimg = evidence.evidenceSprite;
        Image imageDisplay = image.GetComponent<Image>();
        imageDisplay.sprite = evidenceimg;

        if (evidence == null)
        {
            unselectedBorder.SetActive(false);
        }
        else
        {
            unselectedBorder.SetActive(true);
        }

        if (selected)
        {
            ColorUtility.TryParseHtmlString("7A906F", out colorHex);
            //slotColor = colorHex;
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

    public void AssignEvidence(EvidenceSO evidenceAssignment)
    {
        evidence = evidenceAssignment;
    }
}
