using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public DialogueContainer dialogueContainer = new DialogueContainer();

    public static DialogueSystem instance;

    private void Awake()
    {
        instance = this;

        //Ensure only one singleton exists in the scene
        if(instance == null)
            instance = this;
        else
            DestroyImmediate(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
