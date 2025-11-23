using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class PhoneManagerScript : MonoBehaviour
{

    [SerializeField]private GameObject phonePanel;

    // ensures when the scene starts, the phone is off
    void Awake()
    {
        phonePanel.SetActive(false);
    }

    public void OpenPhone()
    {
        
        phonePanel.SetActive(true);

    }

    public void ClosePhone()
    {
        
        phonePanel.SetActive(false);

    }

    // if phone is clicked on, phone screen will open
    void OnMouseDown()
    {
        Debug.Log("Is Clicked");
        OpenPhone();
    }


}
