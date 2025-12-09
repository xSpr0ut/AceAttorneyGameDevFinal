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

    public void LoadScene1(string sceneName)
    {
        currentScene = sceneName;
        SceneManager.LoadScene(sceneName);
    }

    //     scene management

    public void SwitchSceneTime(string sceneName)
    {

        currentScene = sceneName;
        Debug.Log("SCENE MANAGER RUNNING");
        
        switch (sceneName)
        {

            case "NadineScene1":
                LoadScene1("CoWorkerScene1");
                break;

            case "CoWorkerScene1":
                LoadScene1("ManagerScene1");
                break;

            case "ManagerScene1":
                LoadScene1("InvestigationScene1");
                break;

            case "CoWorkerScene2":
                Debug.Log("HELLO! TRANSITIONING TO PHONE SCENE!");
                LoadScene1("PhoneScene1");
                break;
            
        }


    }

    // Update is called once per frame
    void Update()
    {

        if(SceneManager.GetActiveScene().name == "StartScene")
        {
            if (Input.GetKeyDown("space")){
                
               // LoadScene("CoWorkerScene2");
                LoadScene1("NadineScene1");

            }
        }
        
    }
}
