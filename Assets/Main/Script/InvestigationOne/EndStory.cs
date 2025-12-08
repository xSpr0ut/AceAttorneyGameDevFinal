using UnityEngine;

public class EndStory : MonoBehaviour
{
    private const string TargetMessage = "END OF STORY";

    [SerializeField]
    private GameObject dialogue;

    void OnEnable()
    {
        // Subscribe to the log message event
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        // Unsubscribe from the log message event
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        // Check if the current log message matches the target message
        if (logString.Contains(TargetMessage))
        {
            Debug.Log("Detected the target message in the log!");
            dialogue.SetActive(false);
        }
    }
}
