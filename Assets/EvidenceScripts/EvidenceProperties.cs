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
    }

    // Update is called once per frame
    void Update()
    {

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
}
