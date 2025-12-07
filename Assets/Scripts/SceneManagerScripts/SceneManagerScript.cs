using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    // makes script a singleton
    public static SceneManagerScript Instance { get; private set; }
    public String currentScene = "StartScene";

// makes sure there is only ONE scene manager
private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        currentScene = sceneName;
    }

    //     scene management

    public void SwitchSceneTime(string sceneName)
    {

        switch (currentScene)
        {

            case "NadineScene1":
                LoadScene("CoWorkerScene1");
                break;

            case "CoWorkerScene1":
                LoadScene("ManagerScene1");
                break;

            case "ManagerScene1":
                LoadScene("InvestigationScene1");
                break;

            
        }


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(SceneManager.GetActiveScene().name == "StartScene")
        {
            if (Input.GetKeyDown("space")){
                
                LoadScene("NadineScene1");

            }
        }
        
    }
}
