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
                LoadScene1("Investigation1");
                break;

            case "CoWorkerScene2":
                LoadScene1("PhoneScene1");
                break;

            case "NadineScene2":
                LoadScene1("ForensicScene1");
                break;

            case "ForensicScene1":
                LoadScene1("PaparazziScene1");
                break;
            
            case "PaparazziScene1":
                LoadScene1("OlafScene2");
                break;

            case "OlafScene2":
                LoadScene1("ManagerScene2");
                break;

            case "ManagerScene2":
                LoadScene1("Investigation2");
                break;

            case "FanScene2":
                LoadScene1("MakeUpScene2");
                break;

            case "MakeUpScene2":
                LoadScene1("ForensicScene3");
                break;

            case "ForensicScene3":
                LoadScene1("CoWorkerScene3");
                break;

            case "CoWorkerScene3":
                LoadScene1("CrossExam 1");
                break;

            case "CrossExam 1":
                LoadScene1("CrossExam 2");
                break;

            case "CrossExam 2":
                LoadScene1("CrossExam 3");
                break;
            
            case "CrossExam 3":
                LoadScene1("CrossExam 4");
                break;

            case "CrossExam 4":
                LoadScene1("PostTrial");
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
