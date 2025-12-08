using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    [SerializeField]
    private List<SpotsToClickData> spotsToClickList;

    [SerializeField]
    private GameObject dialogue;

    private int objectsInvestigated = 0;

    public TextAsset InkFile;
    private Story currentStory;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else if (Instance != null)
        {
            Destroy(gameObject);
        }

        currentStory = new Story(InkFile.text);
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

            if (hit && hit.collider != null)
            {
                Debug.Log("Clicked: " + hit.collider.gameObject.name);

                hit.collider.gameObject.SetActive(false);
                dialogue.SetActive(true);

                for (int i = 0; i < spotsToClickList.Count; i++)
                {
                    if (spotsToClickList[i].SpotsToClick.name == hit.collider.gameObject.name)
                    {
                        currentStory.ChoosePathString(spotsToClickList[i].description);
                        currentStory.Continue();

                        spotsToClickList.RemoveAt(i);
                        break;
                    }
                }

                objectsInvestigated++;

                if (objectsInvestigated >= 4)
                {
                    Debug.Log("completed");
                }
            }
        }
        
        

        if (Input.GetMouseButtonDown(0))
        {
            dialogue.SetActive(true);

            currentStory.ChoosePathString("Magazine");
            currentStory.Continue();
        }

        

    }
}



[System.Serializable]
public class SpotsToClickData
{
    public string name;
    public GameObject SpotsToClick;
    public string description;
}
