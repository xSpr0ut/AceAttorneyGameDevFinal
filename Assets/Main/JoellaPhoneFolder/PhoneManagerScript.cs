using System;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class PhoneManagerScript : MonoBehaviour
{

    [SerializeField]private GameObject phonePanel;
    [SerializeField]private GameObject dialogueSystem;
    private bool olafKannaContact = false;
    private bool paparazziContact = false;
    private Boolean fanContact = false;


    // ensures when the scene starts, the phone is off
    void Awake()
    {
        phonePanel.SetActive(false);
        dialogueSystem.SetActive(false);
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
    public void OnMouseDown()
    {
        OpenPhone();
    }

    public void OnOlafButtonDown()
    {
        
        dialogueSystem.SetActive(true);
        ClosePhone();
        
    }

    public void OnPaparazziButtonDown()
    {
        
        dialogueSystem.SetActive(true);
        ClosePhone();
        
    }

    public void OnFanButtonDown()
    {
        
        dialogueSystem.SetActive(true);
        ClosePhone();
        
    }


}
